using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace lab4
{
    internal class Plant
    {
        public string Name { get; set; }
        public new decimal cost { get; protected set; }
        public bool CostChange(decimal newCost)
        {
            cost = newCost;
            Debug.Assert(cost == newCost);
            return true;
        }
        public override string ToString()
        {
            return $"{Name} {cost}";
        }
        public static Plant Parse(string str)
        {
            string[] words = str.Split(' ');
            return new Plant(words[0], int.Parse(words[1]));
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Plant other = (Plant) obj;
            return Name == other.Name;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public Plant(string name, int cost)
        {
            Name = name;
            this.cost = cost;
        }
    }
}
