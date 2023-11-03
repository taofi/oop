using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab9
{
    internal class Worker
    {
        public string name;
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Worker other = (Worker)obj;
            return name == other.name;
        }
        public override string ToString()
        {
            return $"{name}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public Worker(string name)
        {
            this.name=name;
        }
    }
}
