using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
  public  class Heater
    {
        private int temperature;
        // 类型
        public string type = "RealFire 001";
        // 产地
        public string area = "china xian";
        //public delegate void BoilHandler(int param);
        // sender 被监视着,e 监视着
        public delegate void BoiledEventHandler(Object sender,BoiledEventArgs e);
        //public event BoilHandler boilHandler;
        public event BoiledEventHandler boiled;
        public class BoiledEventArgs:EventArgs
        {
            public readonly int temperature;
            public BoiledEventArgs(int temp)
            {
                this.temperature = temp;
            }
        }
        // 可以供继承Headter的类重写.以便继承类拒绝其他对象的监视
        public virtual void OnBoiled(BoiledEventArgs e)
        {
            if (boiled!=null)
            {
                boiled(this, e);
            }
        }

        public void BoilWater()
        {
            for (int i=0;i<=100;i++)
            {
                temperature = i;
                if (temperature>=95)
                {
                    //if (boilHandler != null)
                    //{
                    //    boilHandler(temperature);
                    //}
                    BoiledEventArgs e = new BoiledEventArgs(temperature);
                    OnBoiled(e);

                }
            }
        }
    }


}
