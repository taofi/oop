using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal abstract class BaseFinance
    {
        public decimal cost { get; protected set; }
        public abstract bool CostChange(decimal newCost);
    }
}
