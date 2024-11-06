namespace QuanLyKhachHang
{
    public partial class Form1 : Form
    {
        private List<KhachHang> danhSachKhachHang = new List<KhachHang>();
        private int maKhachHangCounter = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDC.Clear();
        }

        private void CapNhatDanhSachKhachHang()
        {
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = danhSachKhachHang;
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txtTenKH.Text;
            string soDienThoai = txtSDT.Text;
            string diaChi = txtDC.Text;

            var khachHang = new KhachHang(maKhachHangCounter++, tenKhachHang, soDienThoai, diaChi);

            danhSachKhachHang.Add(khachHang);
            CapNhatDanhSachKhachHang();
            MessageBox.Show("them thanh cong!");
            ClearTextBoxes();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            int maKhachHang = int.Parse(txtMaKH.Text);

            var khachHang = danhSachKhachHang.FirstOrDefault(kh => kh.MaKhachHang == maKhachHang);
            if (khachHang != null)
            {
                khachHang.TenKhachHang = txtTenKH.Text;
                khachHang.SoDienThoai = txtSDT.Text;
                khachHang.DiaChi = txtDC.Text;

                CapNhatDanhSachKhachHang();
                MessageBox.Show("sua thanh cong!");

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                int index = dgvKhachHang.SelectedRows[0].Index;
                danhSachKhachHang.RemoveAt(index);
                CapNhatDanhSachKhachHang();
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                // Lấy thông tin từ hàng đã chọn và đưa vào các TextBox
                txtMaKH.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDC.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }
    }
}
