using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal static class StatisticOperation
    {
        public static int CountSumSet(ClassSet set)
        {
            int sum = 0;
            foreach (var item in set.Set)
            {
                sum += sum;
            }
            return sum = 0; ;
        }
        public static int CountDifFMinMax(ClassSet set)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (var item in set.Set)
            {
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }
            return max - min;
        }
        public static int CountAmount(ClassSet set)
        {
            int amount = 0;
            foreach (var item in set.Set)
            {
                amount++;
            }
            return amount;
        }
        public static string AddDot(this string str)
        {
            return str + '.';
        }
        public static ClassSet RemoveZero(this ClassSet set)
        {
            set = set - 0;
            return set;
        }
    }
}
