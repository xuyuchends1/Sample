using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class MergeOrders<TOrder> where TOrder : Order
    {
        public IMergeOrderList<TOrder> Merge(TOrder order1, TOrder order2)
        {
            return new MergeOrderList<TOrder>();
        }
    }
    public interface IMergeOrderList<out TOrder> where TOrder : Order
    {
        //void GetOrderList();
    }
    public class MergeOrderList<Torder> : IMergeOrderList<Torder> where Torder : Order
    {
        //void GetOrderList();
    }
}
