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
            IOperationNormalPrice IOperationNormalPrice = new OperationNormalPrices();
            Order order = new Order(items, IOperationNormalPrice);
            var totalPrice = order.GetPrices();

            Order vipOrder = Order.ConvertVipOrder(order);
        }
    }
}
