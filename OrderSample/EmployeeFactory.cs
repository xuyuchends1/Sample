using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class EmployeeFactory
    {
        public static Employee CreateEmployee(string name, string address, Func<string, bool> logic, Func<string, string> filterName)
        {
            if (logic(name))
                return new Employee() { Name = filterName(name), Address = address };
            else
                return new Employee() { Name = name, Address = address };
        }
    }
}
