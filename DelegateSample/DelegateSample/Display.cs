using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
public    class Display
    {
        //public void ShowMsg(int param)
        //{
        //    Console.WriteLine("Display:当前温度{0}度", param);
        //}
        public void ShowMsg(Object sender, Heater.BoiledEventArgs e)
        {
            Heater heater = (Heater)sender;
            Console.WriteLine("Display {0} - {1}", heater.type, heater.area);
            Console.WriteLine("Display :当前温度{0}度", e.temperature);
            Console.WriteLine();
        }
    }
}
