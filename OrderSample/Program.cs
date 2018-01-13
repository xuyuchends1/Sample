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
            Order order = new Order(IOperationNormalPrice);
            var totalPrice = order.GetPrices();

            Order vipOrder = Order.ConvertVipOrder(order);

            //MergeOrders<Order> merge = new MergeOrders<Order>();
            //VipOrder order1 = new VipOrder(new OperationNormalPrices());
            //VipOrder order2 = new VipOrder(new OperationNormalPrices());
            //IMergeOrderList<VipOrder> result = merge.Merge(order1, order2);
        }
    }
}
