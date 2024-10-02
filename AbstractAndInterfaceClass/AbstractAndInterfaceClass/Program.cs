using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaceClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tên sản phẩm điện thoại: ");
            string phoneName = Console.ReadLine();
            Console.Write("Nhập giá sản phẩm điện thoại: ");
            decimal phonePrice = decimal.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng tồn kho điện thoại: ");
            int phoneStock = int.Parse(Console.ReadLine());

            MobilePhone phone = new MobilePhone { Name = phoneName, Price = phonePrice, Stock = phoneStock };

            Console.Write("Nhập tên sản phẩm laptop: ");
            string laptopName = Console.ReadLine();
            Console.Write("Nhập giá sản phẩm laptop: ");
            decimal laptopPrice = decimal.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng tồn kho laptop: ");
            int laptopStock = int.Parse(Console.ReadLine());

            Laptop laptop = new Laptop { Name = laptopName, Price = laptopPrice, Stock = laptopStock };

            Console.Write("Nhập tên sản phẩm phụ kiện: ");
            string accessoryName = Console.ReadLine();
            Console.Write("Nhập giá sản phẩm phụ kiện: ");
            decimal accessoryPrice = decimal.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng tồn kho phụ kiện: ");
            int accessoryStock = int.Parse(Console.ReadLine());

            Accessory accessory = new Accessory { Name = accessoryName, Price = accessoryPrice, Stock = accessoryStock };

            phone.DisplayProductInfo();
            laptop.DisplayProductInfo();
            accessory.DisplayProductInfo();

            phone.Sell(2);
            laptop.Sell(1);
            accessory.Sell(5);

            Console.WriteLine($"Phone in stock: {phone.IsInStock()}");
            Console.WriteLine($"Laptop in stock: {laptop.IsInStock()}");
            Console.WriteLine($"Accessory in stock: {accessory.IsInStock()}");

            phone.ApplyDiscount(10);
            laptop.ApplyDiscount(15);
            accessory.ApplyDiscount(5);

            phone.DisplayProductInfo();
            laptop.DisplayProductInfo();
            accessory.DisplayProductInfo();

            Console.ReadKey();
        }
    }
}
