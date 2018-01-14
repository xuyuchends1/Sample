using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
   public class Employee
    {
        // 只有SourceType== Salary 才转账
        public void TransferToEmployee([TransferSource(TransferType = TransferSourceType.Salary)]int number)
        {
            //汇钱到银行卡
        }
    }
    /// <summary>
    /// 转账类型
    /// </summary>
    public enum TransferSourceType
    {
        Salary,
        Reimburse,
        Loan
    }
}
