using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class VipOrder : Order
    {
        public VipOrder(IOperationNormalPrice ioperationNormalPrice) : base(ioperationNormalPrice)
        {
        }
    }
}
