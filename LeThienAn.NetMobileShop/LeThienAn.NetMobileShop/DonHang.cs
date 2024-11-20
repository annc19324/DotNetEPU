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
    public partial class DonHang : Form
    {
        private string ConnectionString = "Data Source=LAPTOP_ANNC\\MSSQLSERVER_AN;Initial Catalog=MobileShop;User ID=sa;Password=12345;TrustServerCertificate=True;";

        public DonHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM DonHang";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvDonHang.DataSource = table;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idkh = int.Parse(txtkhachhangid.Text);
            int idsp = int.Parse(txtsanphamid.Text);
            int sl = int.Parse(txtsoluong.Text);


            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO DonHang (khachhangid, sanphamid, soluong, ngaymua) VALUES (@kh, @sp, @sl, @ngay)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kh", idkh);
                cmd.Parameters.AddWithValue("@sp", idsp);
                cmd.Parameters.AddWithValue("@sl", sl);
                cmd.Parameters.AddWithValue("@ngay", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string query = "DELETE FROM DonHang WHERE id = @id";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("xoa thanh cong");
            }

        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDonHang.Rows[e.RowIndex];

                id.Text = row.Cells["id"].Value.ToString();
                txtkhachhangid.Text = row.Cells["khachhangid"].Value.ToString();
                txtsanphamid.Text = row.Cells["sanphamid"].Value.ToString();
                txtsoluong.Text = row.Cells["soluong"].Value.ToString();
                dtpngaymua.Value = Convert.ToDateTime(row.Cells["ngaymua"].Value);
            }
            else
            {
                MessageBox.Show("khong co hang nao duoc chon");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int donHangID = int.Parse(id.Text);
            int idkh = int.Parse(txtkhachhangid.Text);
            int idsp = int.Parse(txtsanphamid.Text);
            int sl = int.Parse(txtsoluong.Text);
            DateTime ngayMua = dtpngaymua.Value;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "update donhang set khachhangid = @kh, sanphamid = @sp, soluong = @sl, ngaymua = @ngay WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", donHangID);
                cmd.Parameters.AddWithValue("@kh", idkh);
                cmd.Parameters.AddWithValue("@sp", idsp);
                cmd.Parameters.AddWithValue("@sl", sl);
                cmd.Parameters.AddWithValue("@ngay", ngayMua);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("sua thanh cong");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("sua that bai");
                }
            }
        }

        private void btnTImKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = "select * from DonHang where id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtTimKiem.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvDonHang.DataSource = table;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
