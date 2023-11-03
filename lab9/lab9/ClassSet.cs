using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    internal class ClassSet : IEnumerable
    {
        private HashSet<Worker> _set;
        public IEnumerator GetEnumerator() => _set.GetEnumerator();
        public class Developer
        {
            public string developer;
            public int id;
            public string department;
        }
        public HashSet<Worker> Set
        {
            get { return _set; }
            private set { _set = value; }
        }
        public static ClassSet operator -(ClassSet set, Worker element)
        {
            var newElements = new HashSet<Worker>(set._set);
            newElements.Remove(element);
            return new ClassSet(newElements);
        }
        public static ClassSet operator +(ClassSet set, Worker element)
        {
            var newElements = new HashSet<Worker>(set._set);
            newElements.Add(element);
            return new ClassSet(newElements);
        }

        public ClassSet(IEnumerable<Worker> elements)
        {
            _set = new HashSet<Worker>(elements);
        }
        public ClassSet()
        {
            _set = new HashSet<Worker>();
        }
        public ClassSet(params Worker[] parametrs)
        {
            _set = new HashSet<Worker>(parametrs);
        }
        public void ShowSet()
        {
            foreach (var item in _set)
            {
                Console.Write($"{item.ToString()} ");
            }
            Console.WriteLine();
        }
        public bool Find(string str)
        {
            foreach (var item in _set)
            {
                if (item.name == str)
                    return true;
            }
            return false;
        }
    }
}
