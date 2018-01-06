using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Items items = new Items();
            Order order = new Order(items);
            var totalPrice = order.GetPrices();
        }
    }
}
