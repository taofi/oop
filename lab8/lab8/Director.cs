using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Director
    {
        public delegate void WorkersHandler(double value);
        public event WorkersHandler statusNotify;
        public event WorkersHandler salaryNotify;
        public Director() { }
        public void increase(double value) => statusNotify?.Invoke(value);
        public void fine(double value) => statusNotify?.Invoke(-value);
        public void salary(double value) 
        {
            Console.WriteLine("зарплата выдана"); 
            salaryNotify?.Invoke(value);
        } 
    }
}
