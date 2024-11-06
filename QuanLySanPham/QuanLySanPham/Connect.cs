using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    internal class Connect
    {
        public SqlConnection getConnection()
        {
            string? connectStr = "Server=LAPTOP_ANNC\\MSSQLSERVER_AN;Database=ProductManagement;User Id=sa;Password=12345;Integrated Security=true; TrustServerCertificate=true;";
            SqlConnection connection = new SqlConnection(connectStr);
            return connection;
        }
    }
}
