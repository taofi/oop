using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class ExpPlant : System.Exception
    {
        public int Count { get; set; }
        public ExpPlant(string massage, int value) : base(massage)
        { 
            this.Count = value;
        }

    }
    internal class ExpString : System.Exception 
    {
        public string Value { get; set; }
        public ExpString(string massage, string value) : base(massage)
        {
            this.Value = value;
        }
    }
    internal class PriceExp : ExpPlant
    {
        public PriceExp(string massage, int value) : base(massage, value) { }
    }
    internal class CountExp : ExpPlant
    {
        public CountExp(string massage, int value) : base(massage, value) { }
    }
}
