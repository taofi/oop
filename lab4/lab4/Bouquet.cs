using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4
{
    partial class Bouquet<T> : Paper
    {
        private List<T> flowers = new List<T>();
        public List<T> GetItems()
        {
            return flowers;
        }
        public void SetItems(List<T> newItems)
        {
            flowers = newItems;
        }

        public void AddItem(T item)
        {
            flowers.Add(item);
        }

        public void RemoveItem(T item)
        {
            flowers.Remove(item);
        }

        public void PrintItems()
        {
            foreach (var item in flowers)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public override string ToString()
        {
            return $"paper {size} {flowers} {cost}$";
        }
    }
}
