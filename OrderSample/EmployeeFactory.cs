using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class EmployeeFactory
    {
        public static Employee CreateEmployee(string name, string address)
        {
            if (name.StartsWith("VIP"))
                return new Employee() { Name = name.Replace("VIP", ""), Address = address };
            else
                return new Employee() { Name = name, Address = address };
        }
    }
}
