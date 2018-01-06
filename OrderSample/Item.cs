using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
  public  class Item
    {
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public  virtual double  Price { get; set; }
    }
}
