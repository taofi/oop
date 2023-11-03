using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Operation
    {
        public static string RemovingPunctuationMarks(string str)
        {
            str = str.Replace(",", "");
            str = str.Replace(".", "");
            str = str.Replace("?", "");
            str = str.Replace("!", "");
            return str;
        }
        public static bool HasSpace(string str)
        {
            for (int i = 0; i < str.Length; i++)
                if (str[i] == ' ')
                    return true;
            return false;
        }
        public static string LetterToUpper(string str)
        {
            str = str.ToUpper();
            return str;
        }
        public static string LetterToLower(string str)
        {
            str = str.ToLower();
            return str;
        }
        public static string RemovExtraSpaces(string str)
        {
            str = str.Replace(" ", "");
            return str;
        }
    }
}
