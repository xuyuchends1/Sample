using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            Alarm alarm = new Alarm();
            Display display = new Display();
            heater.boiled += alarm.MakeAlert;
            heater.boiled += display.ShowMsg;
            heater.BoilWater();
            Console.ReadKey();
        }
    }
}
