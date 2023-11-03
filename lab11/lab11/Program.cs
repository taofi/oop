using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reflector.GetAssemblyName();
            Reflector.HasPublicConstructor(typeof(Customer));
            Reflector.PublciMetods(typeof(Customer));
            Reflector.GetPropertyNames(typeof(Customer));
            Reflector.GetFieldNames(typeof(Customer));
            Reflector.GetClassInterfaces(typeof(Customer));
            Reflector.GetMetodByParm(typeof(Customer), "System.Int32");


            Customer customer = Reflector.Create<Customer>("asd", 23, 3);
            Console.WriteLine();
            Console.WriteLine(customer.ToString());
        }
    }
}
