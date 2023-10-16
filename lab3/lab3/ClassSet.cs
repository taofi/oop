using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using lab4;

namespace lab3
{
    internal class ClassSet<T>
    {

        private HashSet<T> _set;
        public Production pr = new Production();
        public class Developer
        {
            public string developer;
            public int id;
            public string department;
        }
        public HashSet<T> Set {
            get { return _set; }
            private set {_set = value; }
        }
        public static ClassSet<T> operator -(ClassSet<T> set, object element)
        {
            var newElements = new HashSet<T>(set._set);
            newElements.Remove((T)element);
            return new ClassSet<T>(newElements);
        }
        public static ClassSet<T> operator +(ClassSet<T> set, object element)
        {
            var newElements = new HashSet<T>(set._set);
            newElements.Add((T)element);
            return new ClassSet<T>(newElements);
        }
        public static ClassSet<T> operator *(ClassSet<T> set1, ClassSet<T> set2)
        {
            var intersection = set1.Set.Intersect(set2.Set);
            return new ClassSet<T>(intersection);
        }
        public static ClassSet<T> operator &(ClassSet<T> set1, ClassSet<T> set2)
        {
            var inh = set1.Set.Union(set2.Set);
            return new ClassSet<T>(inh);
        }

        public static bool operator <(ClassSet<T> set1, ClassSet<T> set2)
        {
            return set1.Set.SetEquals(set2.Set);
        }
        public static bool operator >(ClassSet<T> set1, ClassSet<T> set2)
        {
            return set1.Set.IsSubsetOf(set2.Set);
        }
        public ClassSet(IEnumerable<T> elements)
        {
            _set = new HashSet<T>(elements);
        }
        public ClassSet()
        {
            _set = new HashSet<T>();
        }
        public ClassSet(params T[] parametrs)
        {
            _set = new HashSet<T>(parametrs);
        }
        public void ShowSet ()
        {
            foreach (var item in _set) 
            {
                Console.Write($"{item.ToString()} ");
            }
            Console.WriteLine();
        }
        public void FileSave(string FileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(FileName);
                foreach (var item in _set)
                {
                    sw.WriteLine($"{item.ToString()} ");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public void FileRead(string FileName)
        {
            string line;
            try
            {
                StreamReader sr = new StreamReader(FileName);
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
