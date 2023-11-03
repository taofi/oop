using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Workers workers1 = new Workers();
            Workers workers2 = new Workers();
            Workers workers3 = new Workers();
            Workers workers4 = new Workers();
            Workers workers5 = new Workers();
            Workers workers6 = new Workers();
            director.salaryNotify += workers1.BalanceChange;
            director.salaryNotify += workers2.BalanceChange;
            director.salaryNotify += workers3.BalanceChange;
            director.salaryNotify += workers4.BalanceChange;
            director.salaryNotify += workers5.BalanceChange;
            director.salaryNotify += workers6.BalanceChange;
            director.statusNotify += workers1.CoefficientChange;
            director.statusNotify += workers2.CoefficientChange;
            director.statusNotify += workers6.CoefficientChange;
            director.fine(0.2);
            director.salary(1000);
            director.increase(0.4);
            director.salary(1000);
         
            string str1 = "NooT !tExt 1,Q fff tasdi,S lasjd";

            Console.WriteLine(str1);
            Func<string, string> convertStr = Operation.RemovingPunctuationMarks;
            str1 = convertStr(str1);
            Console.WriteLine(str1);
            convertStr += Operation.RemovExtraSpaces;
            str1 = convertStr(str1);
            Console.WriteLine(str1);
            convertStr += Operation.LetterToUpper;
            str1 = convertStr(str1);
            Console.WriteLine(str1);
            convertStr += Operation.LetterToLower;
            str1 = convertStr(str1);
            Console.WriteLine(str1);
            Predicate<string> provQ = Operation.HasSpace;
            Console.WriteLine($"есть пробелы?: {provQ(str1)}");
        }
    }
}
