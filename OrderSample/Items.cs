using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample
{
    public class Items : List<Item>
    {
        public const string VIPString = "VIP_";
        public const string NormalString = "Normal_";

        public Items()
        {
            this.Add(new Item() { ItemCode = VIPString + "_001", ItemName = "光明牛奶", Price = 36.5 });
            this.Add(new Item() { ItemCode = NormalString + "_001", ItemName = "红富士苹果", Price = 30.5 });
            this.Add(new Item() { ItemCode = VIPString + "_002", ItemName = "蒙牛牛奶", Price = 10 });
            this.Add(new Item() { ItemCode = NormalString + "_002", ItemName = "进口苹果", Price = 60 });
            this.Add(new Item() { ItemCode = NormalString + "_003", ItemName = "进口苹果", Price = 0 });
        }

        public void SetItems(List<Item> items)
        {
            this.Clear();
            foreach (var item in items)
            {
                this.Add(item);
            }
        }
        public List<Item> GetVIPItems()
        {
            if (this.Count == 0)
                return null;
            var result = from item in this where item.ItemCode.StartsWith("VIP") select item;
            return result.ToList();
        }

        public List<Item> GetNormalItems()
        {
            if (this.Count == 0)
                return null;
            var result = from item in this where item.ItemCode.StartsWith("Normal") select item;
            return result.ToList();
        }
    }
}
