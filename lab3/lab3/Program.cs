using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassSet mySet = new ClassSet(2, 3, 4, 5, 6);
            ClassSet mySet2 = new ClassSet(1, 2, 3, 4, 7, 8, 9);
            mySet = mySet - 2;
            foreach (var item in mySet.Set)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
             mySet = mySet * mySet2;
            foreach (var item in mySet.Set)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            mySet = mySet & new ClassSet(1, 10, 0, 2, 3);
            foreach (var item in mySet.Set)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            mySet = mySet.RemoveZero();
            foreach (var item in mySet.Set)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine("asdf".AddDot());
            ClassSet.Developer dev = new ClassSet.Developer();
            dev.id = 0;
            dev.department = "asd";
            dev.developer = "oleg";
            Console.WriteLine($"Id {dev.id}, department {dev.department}, developer {dev.developer}");
            mySet.pr.id = 0;
            mySet.pr.name = "ASD";
            mySet.pr.organisation = "fffs";
            Console.WriteLine($"Id {mySet.pr.id}, organisation {mySet.pr.organisation}, name {mySet.pr.name}");
        }
    }
}
