using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class ConvertOrderHelper
    {
        public Order ConvertVipOrder(Order normalOrer)
        {
            if (normalOrer == null || normalOrer.Items == null || normalOrer.Items.Count == 0)
                return null;
            Order result = new Order(new OperationNormalPrices())
            { Status = normalOrer.Status, Items = new Items() };
            normalOrer.Items.ForEach(item =>
            {
                result.Items.Add(new Item()
                {
                    ItemCode = item.ItemCode,
                    Price = item.Price - 20,
                    ItemName = item.ItemName
                });
            });
            return result;
        }

        private bool ValidatorConvertNormalOrder(Order normalOrder)
        {
            if (normalOrder == null || normalOrder.Items == null || normalOrder.Items.Count == 0)
                return false;
            return true;
        }
    }
}
