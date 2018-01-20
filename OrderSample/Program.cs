using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Items items = new Items();
            //IOperationNormalPrice IOperationNormalPrice = new OperationNormalPrices();
            //Order order = new Order(IOperationNormalPrice);
            //var totalPrice = order.GetPrices();

            //Order vipOrder = Order.ConvertVipOrder(order);

            //MergeOrders<Order> merge = new MergeOrders<Order>();
            //VipOrder order1 = new VipOrder(new OperationNormalPrices());
            //VipOrder order2 = new VipOrder(new OperationNormalPrices());
            //IMergeOrderList<VipOrder> result = merge.Merge(order1, order2);
            //Employee employee = new Employee();
            //HR hr = new HR();
            //hr.ToSalary(employee);
            //hr.ToSalary(employee);

            //Employee employee = EmployeeFactory.CreateEmployee("abc", "strat1");

            //employee.EmployeeNameEvent += Employee_EmployeeNameEvent;
            //employee.ChangeName("acc");

            //LogEntity logEntity = new LogEntity() { Type = LogType.Exception, Level = LogLevel.Error, Content = new LogContent { LogTrackInfo = "Program.Main", Message = "字符串不能为空" } };
            //ILogSaveProvider saveProvider = new LogSaveLocalhostProvider();
            //saveProvider.SaveLog(logEntity);

            Person person = new Person { Name = "Tom" }
    .Run()
    .Sing()
    .Swim();
        }

        //private static void Employee_EmployeeNameEvent(string changedName)
        //{
        //    Console.WriteLine(changedName);
        //    Console.ReadLine();
        //}

    }
}
