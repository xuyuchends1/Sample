using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
   public interface IOperationNormalPrice
    {
        double GetPrices(Order order);
        double GetVipPrices(Order order);
    }
}
