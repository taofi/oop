using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Workers
    {
        
        public double coefficient { get; private set; }
        public double balance { get; private set; }
        public Workers(double cf, double bl)
        {
            coefficient = cf;
            balance = bl;
        }
        public Workers()
        {
            coefficient = 1;
            balance = 0;
        }
        public void CoefficientChange(double value) => coefficient += value;
        public void BalanceChange(double value)
        {
            balance += value * coefficient;
            Console.WriteLine($"зарплата получена {value * coefficient}");
        }
    }
}
