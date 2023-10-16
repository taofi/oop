using lab4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassSet<int> mySet = new ClassSet<int>(2, 3, 4, 5, 6);
            ClassSet<int> mySet2 = new ClassSet<int>(1, 2, 3, 4, 7, 8, 9);
            mySet = mySet - 2;
            mySet.ShowSet();
            mySet = mySet * mySet2;
            mySet.ShowSet();
            mySet = mySet & new ClassSet<int>(1, 10, 0, 2, 3);
            mySet.ShowSet();
            mySet = mySet + 2;
            mySet = mySet + 100;
            mySet.ShowSet();
            ClassSet<Plant> plant = new ClassSet<Plant>(new Plant("asd", 2), new Plant("afgd", 2), new Plant("asd", 90));
            plant = plant + new Plant("asddkajsdjk", 90);
            plant.ShowSet();
            plant.FileSave("plant.txt");
            plant.FileRead("plant.txt");
        }
    }
}
