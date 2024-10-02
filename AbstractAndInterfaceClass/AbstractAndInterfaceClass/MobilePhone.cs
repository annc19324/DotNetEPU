using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaceClass
{
    class MobilePhone : Product, ISellable
    {
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"MobilePhone: {Name}, Price: {Price:C}, Stock: {Stock}");
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
                Console.WriteLine($"{quantity} MobilePhone(s) sold. Stock left: {Stock}");
            }
            else
            {
                Console.WriteLine("Not enough stock for MobilePhone.");
            }
        }

        public bool IsInStock()
        {
            return Stock > 0;
        }
    }

}
