using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
public    class Order
    {
        public int Status { get; set; }
        public Items Items { get; set; }

        public Order(Items items)
        {
            this.Items = items;
        }
        public double GetPrices()
        {
            var normalItemList = Items.GetNormalItems();
            double result = 0.0;
            foreach (var item in normalItemList)
            {
                result += item.Price;
            }

            var VIPItemList = Items.GetVIPItems();
            foreach (var item in VIPItemList)
            {
                result += item.Price;
            }
            return result;
        }
    }
}
