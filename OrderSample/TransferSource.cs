using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public class TransferSource:Attribute// 转账元参数
    {
        public TransferSourceType TransferType { get; set; }
    }
}
