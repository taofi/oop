using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Rose : Bush
    {
        public string color;
        public override string ToString()
        {
            return $"{Name} {amount} {color} {cost}$";
        }
    }
}
