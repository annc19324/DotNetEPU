using System.Windows.Forms;

namespace SanPham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblChucNang.BringToFront();
            lblThongTinn.BringToFront();
            lblDuLieu.BringToFront();

            dataGridView.CellClick += dataGridView1_CellContentClick;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblThongTIn_Click(object sender, EventArgs e)
        {

        }

        private void lblTenSP_Click(object sender, EventArgs e)
        {

        }

        private void lblLoaiSP_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblChucNang_Click(object sender, EventArgs e)
        {

        }

        private void lblDuLieu_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["txtMaSPg"].Value.ToString();
                txtTenSP.Text = row.Cells["txtTenSPg"].Value.ToString();
                txtDonGia.Text = row.Cells["txtDonGiag"].Value.ToString();
                txtHinhAnh.Text = row.Cells["txtHinhAnhg"].Value.ToString();
                txtMoTaNgan.Text = row.Cells["txtMoTaNgang"].Value.ToString();
                richTextBoxMTCT.Text = row.Cells["txtMoTaChiTietg"].Value.ToString() ;

                if (comboBoxLoaiSP.Items.Contains(row.Cells["txtLoaiSanPhamg"].Value.ToString()))
                {
                    comboBoxLoaiSP.SelectedItem = row.Cells["txtLoaiSanPhamg"].Value.ToString();
                }
                else
                {
                    comboBoxLoaiSP.SelectedIndex = -1;
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtHinhAnh.Clear();
            txtMoTaNgan.Clear();
            richTextBoxMTCT.Clear();
            comboBoxLoaiSP.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxMTCT_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
                string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                string.IsNullOrWhiteSpace(txtHinhAnh.Text) ||
                string.IsNullOrWhiteSpace(txtMoTaNgan.Text) ||
                comboBoxLoaiSP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Thêm dòng mới vào DataGridView
            dataGridView.Rows.Add(txtMaSP.Text, txtTenSP.Text, txtDonGia.Text,
            txtHinhAnh.Text, txtMoTaNgan.Text, richTextBoxMTCT.Text,
            comboBoxLoaiSP.SelectedItem.ToString());

            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtHinhAnh.Clear();
            txtMoTaNgan.Clear();
            richTextBoxMTCT.Clear();
            comboBoxLoaiSP.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count >= 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];

                // Cập nhật giá trị của dòng từ các trường nhập liệu
                row.Cells["txtMaSPg"].Value = txtMaSP.Text;
                row.Cells["txtTenSPg"].Value = txtTenSP.Text;
                row.Cells["txtDonGiag"].Value = txtDonGia.Text;
                row.Cells["txtHinhAnhg"].Value = txtHinhAnh.Text;
                row.Cells["txtMoTaNgang"].Value = txtMoTaNgan.Text;
                row.Cells["txtMoTaChiTietg"].Value = richTextBoxMTCT.Text;

                // Cập nhật loại sản phẩm trong ComboBox (nếu hợp lệ)
                if (comboBoxLoaiSP.SelectedItem != null)
                {
                    row.Cells["txtLoaiSanPhamg"].Value = comboBoxLoaiSP.SelectedItem.ToString();
                }

                MessageBox.Show("Thông tin đã được cập nhật!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
                MessageBox.Show("Dòng đã được xóa!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }
    }
}
