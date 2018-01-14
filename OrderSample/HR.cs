using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
 public   class HR
    {
        public void ToSalary(Employee employee)
        {
            var transferSource = typeof(Employee).GetMethod("TransferToEmployee").GetParameters()[0].GetCustomAttributes(false)[0] as TransferSource;
            if (transferSource.TransferType==TransferSourceType.Salary)
            {
                employee.TransferToEmployee(500);
            }
            else
            {
                employee.TransferToEmployee(0);
            }
        }
    }
}
