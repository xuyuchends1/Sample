using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public Person Run()
        {
            Console.WriteLine("Run");
            return this;
        }
        public Person Swim()
        {
            Console.WriteLine("Swim");
            return this;
        }
        public Person Sing()
        {
            Console.WriteLine("Sing");
            return this;
        }

        /// <summary>
        /// 链式代码要求操作有返回值，但对于很多操作大都是void型，什么也不返回，这样就很难链起来了。当然也有解决办法，可能不太优雅。
        ///本人使用扩展方法解决这个问题，首先引入一个泛型扩展：
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public  T Do<T>(this T t, Action<T> action)
        {
            action(t);
            return t;
        }
    }
}
