using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class OrderDistribute : IDistribute<Order>
    {
        public void DistributeOrder(Order t)
        {
            throw new NotImplementedException();
        }
    }
    public class DistributeFactory
    {
        public static OrderDistribute Create()
        {
            return new OrderDistribute();
        }
    }
    public class DistributeHelper
    {
        IDistribute<Order> distribute = DistributeFactory.Create();
        public void OrderDistribute(Order order)
        {
            distribute.DistributeOrder(order);
        }
        public void VipOrderDistribute(Order order)
        {
            distribute.DistributeVipOrder(order);
        }
    }
    public static class DistributeExtends
    {
        public static void DistributeVipOrder(this IDistribute<Order> distribute,Order order )
        {

        }
    }
}
