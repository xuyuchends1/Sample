using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class Order
    {
        public int Status { get; set; }

        private Items items;

        public Items Items
        {
            get
            {
                var v = from a in items where a.Price > 0 select a;
                items.SetItems(v.ToList());
                return items;
            }
            set
            {
                this.items = value;
            }
        }

        private IOperationNormalPrice ioperationNormalPrice;
        public Order(Items items, IOperationNormalPrice ioperationNormalPrice)
        {
            this.Items = items;
            this.ioperationNormalPrice = ioperationNormalPrice;
        }
        public double GetPrices()
        {
            return this.ioperationNormalPrice.GetPrices(this);
        }

        public static Order ConvertVipOrder(Order normalOrder)
        {
            if (normalOrder == null || normalOrder.items == null || normalOrder.items.Count == 0)
                return null;
            Order result = new Order(null, normalOrder.ioperationNormalPrice) { Status = normalOrder.Status, Items = new Items() };
            result.items.Clear();
            // 每个item都会调用
            normalOrder.items.ForEach(item =>
            {
                result.items.Add(new Item
                {
                    ItemCode = item.ItemCode,
                    Price = item is NormalItem ? item.Price - 20 : item.Price,
                    ItemName = item.ItemName
                });
            });
            return result;
        }
    }
}

