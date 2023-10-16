using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Cactus : Bush
    {
        public string type;
        public override string ToString()
        {
            return $"{Name} {amount} {type} {cost}$";
        }
    }
}
