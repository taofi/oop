using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Paper : BaseFinance, IFinance
    {
        public new decimal cost { get; protected set; }
        public override bool CostChange(decimal newCost)
        {
            if (newCost < 0)
            {
                throw new PriceExp("Error cost < 0", (int)newCost);
            }
            cost = newCost;
            return true;
        }
        public int size;
        public override string ToString()
        {
            return $"paper {size} {cost}$";
        }
    }
}
