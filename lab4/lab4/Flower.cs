using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Flower : Plant
    {
        public int count { get; set; }
        public string color { get; set; }
        public Flower(string name, string Color, int Cost, int count)
        {
            Name = name;
            if(Name.Any(char.IsDigit))
            {
                throw new ExpString($"Error name has numbers {Name}", Name);
            }
            color = Color;
            if (Cost < 0)
            {
                throw new PriceExp($"Error cost {Cost} < 0", Cost);
            }
            cost = Cost;
            if (count < 0)
            {
                throw new CountExp($"Error count {count} < 0", count);
            }
            this.count=count;
        }
        public override string ToString()
        {
            return $"{Name} {color} {cost}$";
        }
    }
}
