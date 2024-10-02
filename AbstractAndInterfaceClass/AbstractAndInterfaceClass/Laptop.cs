using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaceClass
{
    class Laptop : Product, ISellable
    {
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Laptop: {Name}, Price: {Price:C}, Stock: {Stock}");
        }

        public override void ApplyDiscount(decimal percentage)
        {
            Price -= Price * percentage / 100;
        }

        public void Sell(int quantity)
        {
            if (Stock >= quantity)
            {
                Stock -= quantity;
                Console.WriteLine($"{quantity} Laptop(s) sold. Stock left: {Stock}");
            }
            else
            {
                Console.WriteLine("Not enough stock for Laptop.");
            }
        }

        public bool IsInStock()
        {
            return Stock > 0;
        }
    }

}
