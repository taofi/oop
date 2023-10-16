using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Bush : Plant
    {
        public int amount;
       
        public override string ToString()
        {
            return $"{Name} {amount} {cost}";
        }
    }
}
