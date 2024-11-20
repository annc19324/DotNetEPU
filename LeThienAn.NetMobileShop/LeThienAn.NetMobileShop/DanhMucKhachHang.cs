using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeThienAn.NetMobileShop
{

    public partial class DanhMucKhachHang : Form
    {
        private string ConnectionString = "Data Source=LAPTOP_ANNC\\MSSQLSERVER_AN;Initial Catalog=MobileShop;User ID=sa;Password=12345;TrustServerCertificate=True;";

        public DanhMucKhachHang()
        {
            InitializeComponent();
        }

        private void DanhMucKhachHang_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM KhachHang";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvDMKH.DataSource = table;
            }
        }
        private void dgvDMKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
