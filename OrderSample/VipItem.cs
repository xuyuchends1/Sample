using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class VipItem : Item
    {
        private double price;

        public override double Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
