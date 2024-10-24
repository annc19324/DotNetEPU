using System.Text.RegularExpressions;

namespace ProjectQuanLyThongTinSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbGT.Items.Add("Nam");
            cbbGT.Items.Add("Nữ");
            cbbGT.Items.Add("Không đề cập");

            cbbKhoa.Items.AddRange(new String[] {
                "CNTT",
                "Mảketing",
                "Logistic và chuỗi quản lý cung ứng",
                "Du Lịch" });
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private bool KtraEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool KtraSDT(string sdt)
        {
            string sdtPattern = @"^0[0-9]{9}$";
            return Regex.IsMatch(sdt, sdtPattern);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMSV.Text) || string.IsNullOrEmpty(tbHoTen.Text))
            {
                MessageBox.Show("bat buoc phai nhap day du Ma Sinh Vien va Ho Ten!");
                tbMSV.Focus();
                return;
            }

            string email = tbEmail.Text;
            string sdt = tbSDT.Text;
            if (!KtraEmail(email))
            {
                MessageBox.Show("định dạng email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmail.Focus();
                return;
            }

            if (!KtraSDT(sdt))
            {
                MessageBox.Show("định dạng số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSDT.Focus();
                return;
            }


            SinhVien sv = new SinhVien()
            {
                MaSV = tbMSV.Text,
                HoTen = tbHoTen.Text,
                NgaySinh = tbNgaySinh.Text,
                DiaChi = tbDiaChi.Text,
                Email = tbEmail.Text,
                SDT = tbSDT.Text,
                GioiTinh = cbbGT.SelectedItem.ToString(),
                Khoa = cbbKhoa.SelectedItem.ToString()
            };

            QuanLySinhVien.Instance.ThemSinhVien(sv);
            MessageBox.Show("Thêm mới thành công", "thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiDanhSachSinhVien();
            Clear();
        }

        private void Clear()
        {
            tbMSV.Clear();
            tbHoTen.Clear();
            tbNgaySinh.Clear();
            tbDiaChi.Clear();
            tbEmail.Clear();
            tbSDT.Clear();
            cbbGT.SelectedIndex = -1;
            cbbKhoa.SelectedIndex = -1;

        }

        public void HienThiDanhSachSinhVien()
        {
            dgvDSSV.DataSource = null;
            dgvDSSV.DataSource = QuanLySinhVien.Instance.DanhSachSinhVien;
        }

        private void tbMSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSSV.SelectedRows.Count > 0)
            {
                int index = dgvDSSV.SelectedRows[0].Index;

                SinhVien sv = QuanLySinhVien.Instance.DanhSachSinhVien[index];

                sv.HoTen = tbHoTen.Text;
                sv.NgaySinh = tbNgaySinh.Text;
                sv.DiaChi = tbDiaChi.Text;
                sv.Email = tbEmail.Text;
                sv.SDT = tbSDT.Text;
                sv.GioiTinh = cbbGT.SelectedItem.ToString();
                sv.Khoa = cbbKhoa.SelectedItem.ToString();
                MessageBox.Show("sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDanhSachSinhVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSSV.SelectedRows.Count > 0)
            {
                int index = dgvDSSV.SelectedRows[0].Index;

                QuanLySinhVien.Instance.DanhSachSinhVien.RemoveAt(index);

                HienThiDanhSachSinhVien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMSV.Clear();
            tbHoTen.Clear();
            tbNgaySinh.Clear();
            tbDiaChi.Clear();
            tbEmail.Clear();
            tbSDT.Clear();

            cbbGT.SelectedIndex = -1;
            cbbKhoa.SelectedIndex = -1;
        }

        private void cbbGT_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                SinhVien sv = QuanLySinhVien.Instance.DanhSachSinhVien[index];
                tbMSV.Text = sv.MaSV;
                tbHoTen.Text = sv.HoTen;
                tbNgaySinh.Text = sv.NgaySinh;
                tbDiaChi.Text = sv.DiaChi;
                tbEmail.Text = sv.Email;
                tbSDT.Text = sv.SDT;
                cbbGT.SelectedItem = sv.GioiTinh;
                cbbKhoa.SelectedItem = sv.Khoa;
            }
        }

        private void tbMSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbHoTen.Focus();
            }
        }

        private void tbHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbNgaySinh.Focus();
            }
        }

        private void tbNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbDiaChi.Focus();
            }
        }

        private void tbDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbEmail.Focus();
            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbSDT.Focus();
            }
        }

        private void tbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cbbGT.Focus();
                cbbGT.DroppedDown = true;
            }
        }

        private void cbbGT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cbbKhoa.Focus();
                cbbKhoa.DroppedDown = true;
            }
        }

        private void cbbKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnThem.Focus();
            }
        }
    }
}
