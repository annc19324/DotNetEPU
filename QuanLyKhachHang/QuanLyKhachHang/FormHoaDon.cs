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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            cmbKhachHang.DataSource = DataStortage.DanhSachKhachHang;
            cmbKhachHang.DisplayMember = "TenKhachHang";
            cmbKhachHang.ValueMember = "MaKhachHang";

            lstDichVu.DataSource = DataStortage.DanhSachDichVu;
            lstDichVu.DisplayMember = "TenDichVu";
        }
        private void CapNhatTongTien()
        {
            decimal tongTien = 0;
            foreach (DichVu dv in lstDichVuDaChon.Items)
            {
                tongTien += dv.GiaTien;
            }
            lblTongTien.Text = $"Tổng tiền: {tongTien:C}";
        }
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            var dichVu = (DichVu)lstDichVu.SelectedItem;
            if (dichVu != null)
            {
                lstDichVuDaChon.Items.Add(dichVu);
                CapNhatTongTien();
            }
        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            if (lstDichVuDaChon.SelectedItem != null)
            {
                lstDichVuDaChon.Items.Remove(lstDichVuDaChon.SelectedItem);
                CapNhatTongTien();
            }
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            var khachHang = (KhachHang)cmbKhachHang.SelectedItem;
            var danhSachDichVu = new List<DichVu>();

            foreach (DichVu dv in lstDichVuDaChon.Items)
            {
                danhSachDichVu.Add(dv);
            }

            int maHoaDon = DataStortage.DanhSachHoaDon.Count + 1;  // Tạo mã hóa đơn tự động
            var hoaDon = new HoaDon(maHoaDon, khachHang, danhSachDichVu);

            // Lưu hóa đơn vào danh sách hóa đơn
            DataStortage.DanhSachHoaDon.Add(hoaDon);

            MessageBox.Show("Hóa đơn đã được tạo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Làm sạch danh sách dịch vụ đã chọn và tổng tiền sau khi tạo hóa đơn
            lstDichVuDaChon.Items.Clear();
            CapNhatTongTien();
        }
    }
}
