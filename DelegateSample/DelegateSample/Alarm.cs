using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
public    class Alarm
    {
        //public void MakeAlert(int param)
        //{
        //    Console.WriteLine("alarm 水已经{0}度了", param);
        //}
        public void MakeAlert(Object sender,Heater.BoiledEventArgs e)
        {
            Heater heater = (Heater)sender;
            Console.WriteLine("alarm {0} - {1}", heater.type,heater.area);
            Console.WriteLine("alarm 水已经{0}度了", e.temperature);
            Console.WriteLine();
        }
    }
}
