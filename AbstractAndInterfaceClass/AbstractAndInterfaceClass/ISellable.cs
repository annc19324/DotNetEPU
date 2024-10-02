using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaceClass
{
    interface ISellable
    {
        void Sell(int quantity);
        bool IsInStock();
    }
}
