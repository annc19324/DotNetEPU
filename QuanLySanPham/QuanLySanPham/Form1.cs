using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLySanPham
{
    public partial class Form1 : Form
    {
        private ProductController productController;
        public Form1()
        {
            InitializeComponent();
            productController = new ProductController();
            loadData();

        }

        void loadData()
        {
            dgv.DataSource = null;
            dgv.DataSource = productController.getData();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ShowDataGridView()
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ProductName = txtProductName.Text;
            string Description = txtDescription.Text;
            decimal Price = decimal.Parse(txtPrice.Text);
            int Quantity = int.Parse(txtQuantity.Text);
            productController.addProduct(new Product(ProductName, Description, Price, Quantity));
            ClearTxt();
            loadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ProductID = int.Parse(txtProductID.Text);
            string ProductName = txtProductName.Text;
            string Description = txtDescription.Text;
            decimal Price = decimal.Parse(txtPrice.Text);
            int Quantity = int.Parse(txtQuantity.Text);
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn sửa sản phẩm có id {ProductID} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productController.editProduct(new Product(ProductID, ProductName, Description, Quantity));
                ClearTxt();
                loadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ProductID = int.Parse(txtProductID.Text);
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm có id {ProductID} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productController.deleteProduct(ProductID);
                ClearTxt();
                loadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            

        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtDescription.Text = row.Cells["Décription"].Value.ToString();
            }
        }

        private void ClearTxt()
        {
            txtProductName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
