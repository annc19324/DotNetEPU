using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    public class Product
    {
        public Product(string? productName, string? description, decimal price, int quantity)
        {
            ProductName = productName;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public Product(int productID, string? productName, string description, decimal price, int quantity)
        {
            ProductID = productID;
            ProductName = productName;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public int ProductID { get; set; }
        public string? ProductName {  get; set; }
        public string ?Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    



}
