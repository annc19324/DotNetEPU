using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaceClass
{
    class Accessory : Product, ISellable
    {
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Accessory: {Name}, Price: {Price}đ, Stock: {Stock}");
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
                Console.WriteLine($"{quantity} Accessory(ies) sold. Stock left: {Stock}");
            }
            else
            {
                Console.WriteLine("Not enough stock for Accessory.");
            }
        }

        public bool IsInStock()
        {
            return Stock > 0;
        }
    }

}
