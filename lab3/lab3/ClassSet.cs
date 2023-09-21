using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab3
{
    internal class ClassSet
    {
        private HashSet<int> _set;
        public Production pr = new Production();
        public class Developer
        {
            public string developer;
            public int id;
            public string department;
        }
        public HashSet<int> Set {
            get { return _set; }
            private set {_set = value; }
        }
        public static ClassSet operator -(ClassSet set, int element)
        {
            var newElements = new HashSet<int>(set._set);
            newElements.Remove(element);
            return new ClassSet(newElements);
        }
        public static ClassSet operator +(ClassSet set, int element)
        {
            var newElements = new HashSet<int>(set._set);
            newElements.Add(element);
            return new ClassSet(newElements);
        }
        public static ClassSet operator *(ClassSet set1, ClassSet set2)
        {
            var intersection = set1.Set.Intersect(set2.Set);
            return new ClassSet(intersection);
        }
        public static ClassSet operator &(ClassSet set1, ClassSet set2)
        {
            var inh = set1.Set.Union(set2.Set);
            return new ClassSet(inh);
        }

        public static bool operator <(ClassSet set1, ClassSet set2)
        {
            return set1.Set.SetEquals(set2.Set);
        }
        public static bool operator >(ClassSet set1, ClassSet set2)
        {
            return set1.Set.IsSubsetOf(set2.Set);
        }
        public ClassSet(IEnumerable<int> elements)
        {
            _set = new HashSet<int>(elements);
        }
        public ClassSet()
        {
            _set = new HashSet<int>();
        }
        public ClassSet(params int[] parametrs)
        {
            _set = new HashSet<int>(parametrs);
        }
    }
}
