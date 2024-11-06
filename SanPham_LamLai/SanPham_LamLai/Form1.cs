namespace SanPham_LamLai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbLSP.Items.AddRange(new String[] {
                "Công nghệ",
                "Thời trang",
                "Thực phẩm",
                "Đồ dùng học tập"
            });



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setCenter(panel1, this);
        }

        private void setCenter(Control item, Control container)
        {
            int x = (container.ClientSize.Width - item.Width) / 2;
            int y = (container.ClientSize.Height - item.Height) / 2;
            item.Location = new Point(x, y);
            item.Anchor = AnchorStyles.None;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        public void HienThiDanhSachSanPham()
        {
            dgvDSSP.DataSource = null;
            dgvDSSP.DataSource = QuanLySanPham.Instance.DanhSachSanPham;
        }

        private void Clear()
        {
            tbMSP.Clear();
            tbTSP.Clear();
            tbHA.Clear();
            tbDG.Clear();
            tbMTN.Clear();
            rtbMTCT.Clear();
            cbbLSP.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMSP.Text))
            {
                MessageBox.Show("không được để trống mã sản phẩm!");
                tbMSP.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbTSP.Text))
            {
                MessageBox.Show("cần nhập tên cho sản phẩm");
                tbTSP.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(tbDG.Text)) {

                MessageBox.Show("cần nhập thông tin về giá cho sản phầm!");
                tbDG.Focus();
                return;
            }

            decimal donGia;
            if(!decimal.TryParse(tbDG.Text, out donGia))
            {
                MessageBox.Show("đơn giá phải là số hợp lệ!");
                tbDG.Focus();
                return;
            }

            SanPham sp = new SanPham()
            {
                MaSP = tbMSP.Text,
                TSP = tbTSP.Text,
                DG = donGia,
                HA = tbHA.Text,
                MTN = tbMTN.Text,
                MTCT = rtbMTCT.Text,
                LSP = cbbLSP.SelectedItem != null ? cbbLSP.SelectedItem.ToString() : "null"
            }; 

            QuanLySanPham.Instance.ThemSanPham(sp);
            HienThiDanhSachSanPham();
            MessageBox.Show("thêm thành công", "thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();

        }
    }
}
