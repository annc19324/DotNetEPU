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
    public partial class thongke : Form
    {
        private string ConnectionString = "Data Source=LAPTOP_ANNC\\MSSQLSERVER_AN;Initial Catalog=MobileShop;User ID=sa;Password=12345;TrustServerCertificate=True;";

        public thongke()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                cbThang.Items.Add(i);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cbThang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tháng để thống kê!");
                return;
            }

            int thang = int.Parse(cbThang.SelectedItem.ToString());

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string query = @"
                select 
                    DonHang.id AS MaDonHang,
                    SanPham.tenSP AS TenSanPham,
                    DonHang.soluong AS SoLuong,
                    SanPham.gia AS GiaSanPham,
                    (DonHang.soluong * SanPham.gia) as ThanhTien,
                    DonHang.ngaymua AS NgayMua
                from DonHang
                inner JOIN SanPham ON DonHang.sanphamid = SanPham.id
                where month(DonHang.ngaymua) = @thang";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@thang", thang);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvThongKe.DataSource = table;

                decimal tongDoanhThu = 0;
                foreach (DataRow row in table.Rows)
                {
                    tongDoanhThu += Convert.ToDecimal(row["ThanhTien"]);
                }
                lblDoanhThu.Text = $"tong doanh thu: {tongDoanhThu}VND";
            }

        }
    }
}
