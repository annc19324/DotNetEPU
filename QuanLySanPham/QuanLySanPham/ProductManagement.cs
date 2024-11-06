using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    public class ProductManagement
    {
        private static ProductManagement instance;
        public static ProductManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductManagement();

                }
                return instance;
            }
        }

        public List<Product> ProductList { get; set; }
        private ProductManagement()
        {
            ProductList = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            ProductList.Add(product);
        }
    }

}
