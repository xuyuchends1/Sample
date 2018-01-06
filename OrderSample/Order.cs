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
                this.items = value ;
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
    }
}
