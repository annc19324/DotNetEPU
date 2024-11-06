using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    internal class ProductController
    {
        private SqlConnection conn;

        public ProductController()
        {
            conn = new Connect().getConnection();
        }

        public bool addProduct(Product p)
        {
            try
            {
                string query = "insert into Products values(@ProductName, @Description, @Price, @Quantity)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", p.ProductName);
                    cmd.Parameters.AddWithValue("@Description", p.Description);
                    cmd.Parameters.AddWithValue("@Price", p.Price);
                    cmd.Parameters.AddWithValue("@Quantity", p.Quantity);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteProduct(int ProductID)
        {
            try
            {
                string query = "delete Products where ProductID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", p.ProductID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool editProduct(Product p)
        {
            try
            {
                string query = "update Products set ProductName = @ProductID, Description = @Description, Price = @Price where ProductID = @ProductID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", p.ProductID);
                    cmd.Parameters.AddWithValue("@ProductID", p.ProductID);
                    cmd.Parameters.AddWithValue("@Description", p.Description);
                    cmd.Parameters.AddWithValue("@Price", p.Price);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public DataTable getData()
        {
            DataTable ds = new DataTable();
            try
            {
                string query = "select * from Products";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                return ds;
            }
        }
    }
}
