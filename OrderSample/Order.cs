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
