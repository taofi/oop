using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class Program
    {
        static void Change(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                        Console.WriteLine($"Добавлен новый объект");
                    break;
                case NotifyCollectionChangedAction.Remove:
                        Console.WriteLine($"Удален объект");
                    break;
                case NotifyCollectionChangedAction.Replace:
                        Console.WriteLine($"Объект заменен ");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Worker gleb = new Worker("gleb");
            ClassSet workerSet = new ClassSet(gleb, new Worker("oleg"), new Worker("asd"));
            workerSet = workerSet + gleb;
            workerSet = workerSet + new Worker("asdfff");
            workerSet.ShowSet();
            Console.WriteLine(workerSet.Find("gleb"));
            workerSet = workerSet - gleb;
            Console.WriteLine(workerSet.Find("gleb"));
            HashSet<int> newSet = new HashSet<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            newSet.Add(10);
            newSet.UnionWith(new HashSet<int>(new int[] { 1, 20, 30, 4, 5 }));
            HashSet<int> sSet = new HashSet<int>();
            int count = 0;
            foreach (var item in newSet)
            {
                if (count >= 3) break;
                sSet.Add(item);
                count++;
            }
            foreach (var item in sSet){newSet.Remove(item);}
            foreach (int i in newSet) 
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            List<int> list = new List<int>();
            foreach (var item in newSet)
            {
                list.Add(item);
            }
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            ObservableCollection<Worker> workers = new ObservableCollection<Worker>();
            workers.CollectionChanged += Change;
            workers.Add(new Worker("asd"));
            workers.Add(new Worker("asd"));
            workers.RemoveAt(0);
        }
    }
}
