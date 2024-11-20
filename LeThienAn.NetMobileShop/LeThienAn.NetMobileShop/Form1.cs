using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using Microsoft.Data.SqlClient;

namespace LeThienAn.NetMobileShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=LAPTOP_ANNC\\MSSQLSERVER_AN;Initial Catalog=MobileShop;User ID=sa;Password = 12345; Trust Server Certificate=True; Integrated Security=true";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "select count (*) from nguoidung where  tendangnhap = @tendangnhap AND matkhau = @matkhau";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tendangnhap", txtTenDangNhap.Text);
                cmd.Parameters.AddWithValue("@matkhau", txtMatKhau.Text);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    FormMain formMain = new FormMain();
                    this.Hide();
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show("sai ten dang nhap hoac mat khau.");
                }
            }
        }
    }
}
