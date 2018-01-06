using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class OperationNormalPrices : IOperationNormalPrice
    {
        public double GetPrices(Order order)
        {
            var normalItemList = order.Items.GetNormalItems();
            double result = 0;
            foreach (var item in normalItemList)
            {
                result += item.Price;
            }
            var vipItemList = order.Items.GetVIPItems();
            foreach (var item in vipItemList)
            {
                result += item.Price;
            }
            return result;
        }

        public double GetVipPrices(Order order)
        {
            double result = 0;
            var vipItemList = order.Items.GetVIPItems();
            foreach (var item in vipItemList)
            {
                result += item.Price + 20;
            }
            return result;
        }
    }
}
