using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace lab4
{
    internal class Plant: BaseFinance, IFinance
    {
        public string Name { get; set; }
        public new decimal cost { get; protected set; }
        public override bool CostChange(decimal newCost)
        {
            if (newCost < 0)
            {
                throw new PriceExp("Error cost < 0", (int)newCost);
            }
            cost = newCost;
            Debug.Assert(cost == newCost);
            return true;
        }
        public override string ToString()
        {
            return $"{Name} {cost}";
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
        
    }
}
