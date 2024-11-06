using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachHang
{
    public partial class DanhSachDichVu : Form
    {
        private List<DichVu> danhSachDichVu = new List<DichVu>();
        private int maDichVuCounter = 1; // Đếm tự động để tạo mã dịch vụ

        public DanhSachDichVu()
        {
            InitializeComponent();
        }
        private void CapNhatDanhSachDichVu()
        {
            dgvDichVu.DataSource = null;
            dgvDichVu.DataSource = danhSachDichVu;
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            string tenDichVu = txtTenDV.Text;
            decimal giaTien;

            if (decimal.TryParse(txtGiaTien.Text, out giaTien))
            {
                var dichVu = new DichVu(maDichVuCounter++, tenDichVu, giaTien);

                danhSachDichVu.Add(dichVu);

                CapNhatDanhSachDichVu();

                MessageBox.Show("Dịch vụ đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Giá tiền phải là một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];

                txtMaDV.Text = row.Cells["MaDichVu"].Value.ToString();
                txtTenDV.Text = row.Cells["TenDichVu"].Value.ToString();
                txtGiaTien.Text = row.Cells["GiaTien"].Value.ToString();
            }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            int maDichVu = int.Parse(txtMaDV.Text);

            var dichVu = danhSachDichVu.FirstOrDefault(dv => dv.MaDichVu == maDichVu);
            if (dichVu != null)
            {
                dichVu.TenDichVu = txtTenDV.Text;
                decimal giaTien;

                if (decimal.TryParse(txtGiaTien.Text, out giaTien))
                {
                    dichVu.GiaTien = giaTien;
                    CapNhatDanhSachDichVu();

                    MessageBox.Show("Dịch vụ đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Giá tiền phải là một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            int maDichVu = int.Parse(txtMaDV.Text);

            var dichVu = danhSachDichVu.FirstOrDefault(dv => dv.MaDichVu == maDichVu);
            if (dichVu != null)
            {
                danhSachDichVu.Remove(dichVu);
                CapNhatDanhSachDichVu();

                MessageBox.Show("Dịch vụ đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
