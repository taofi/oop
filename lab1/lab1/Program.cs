using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bVar = true;
            Console.WriteLine(bVar);
            byte byteVar = 1;
            Console.WriteLine(byteVar);
            char chVar = 'a';
            Console.WriteLine(chVar);
            decimal decVar = 12.5m;
            Console.WriteLine(decVar);
            double dbVar = 4.53;
            Console.WriteLine(dbVar);
            float fVar = 6.8f;
            Console.WriteLine(fVar);
            int iVar = 2556;
            Console.WriteLine(iVar);
            long lVar = 1231415;
            Console.WriteLine(lVar);
            short sVar = 999;
            Console.WriteLine(sVar);


            Console.WriteLine("неявные");
            iVar = chVar;
            Console.WriteLine(iVar);
            iVar = sVar;
            Console.WriteLine(iVar);
            lVar = sVar;
            Console.WriteLine(lVar);
            lVar = iVar;
            Console.WriteLine(lVar);
            dbVar = fVar;
            Console.WriteLine(dbVar);
            dbVar = 67.8;
            Console.WriteLine("явные");
            iVar = (int)dbVar;
            Console.WriteLine(iVar);
            iVar = (int)fVar;
            Console.WriteLine(iVar);
            sVar = (short)lVar;
            Console.WriteLine(sVar);
            iVar = (int)lVar;
            Console.WriteLine(iVar);
            chVar = (char)sVar;
            Console.WriteLine(chVar);

            Console.WriteLine("convert");
            string str = Convert.ToString(iVar);
            Console.WriteLine(str);

            Object boxedI = iVar;
            int unBoxedI = (int)iVar;
            Console.WriteLine(boxedI + " " + unBoxedI);
            var varI = 123;
            Console.WriteLine(varI);
            var varD = 123.123;
            Console.WriteLine(varD);
            Nullable<int> nullableI = 2;
            Console.WriteLine(nullableI);
            nullableI = null;
            Console.WriteLine(nullableI);

            string str1 = "asd dd";
            string str2 = "sdgs sss";
            string str3 = " fss as sda sasd h";
            string str4 = str1;
            Console.WriteLine(str1 + str3);
            Console.WriteLine(string.Concat(str1, str2));
            Console.WriteLine(str4);
            string[] words = str3.Split(new char[] { ' ' });
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            str2 = str2.Insert(3, str1);
            Console.WriteLine(str2);
            str2 = str2.Remove(2, 3);
            Console.WriteLine(str2);
            Console.WriteLine($"str1: {str1}, str2: {str2}, str3: {str3}");
            string strEmpty = "";
            string strNull = null;
            Console.WriteLine($"str1: {string.IsNullOrEmpty(str1)}, strEmpty: {string.IsNullOrEmpty(strEmpty)}, strNull: {string.IsNullOrEmpty(strNull)}");
            StringBuilder strBuild = new StringBuilder("text");
            strBuild.Remove(1, 2);
            strBuild.Append(" !!!");
            strBuild.Insert(0, "123");
            Console.WriteLine(strBuild);
            int[,] dbArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(dbArray[i, j]);
                }
                Console.WriteLine();
            }
            string[] strArray = { "asdd ", "dq2 s", "asf22 ", "sg3a" };
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(strArray.Length);
            int pos = int.Parse(Console.ReadLine());
            string newS = Console.ReadLine();
            strArray[pos] = newS;
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
            int[][] stypArray = new int[3][];
            int x;
            for (int i = 0; i < 3; i++)
            {
                stypArray[i] = new int[i + 2];
                for (int j = 0; j < i + 2; j++)
                {
                    x = int.Parse(Console.ReadLine());
                    stypArray[i][j] = x;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < i + 2; j++)
                {
                    Console.Write(stypArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            var vIntArray = new[] { 0, 1, 2, 4, 5 };
            var vStrArray = new[] { "12", "as2", "3sa" };
            foreach (var i in vIntArray)
                Console.WriteLine(i);
            foreach (var i in vStrArray)
                Console.WriteLine(i);
            (int, string, char, string, ulong) typle = (2, "str1", 'c', "str2", 124567);
            (int, string, char, string, ulong) typle2 = (2, "str1", 'c', "str2", 124567);
            Console.WriteLine(typle);
            Console.WriteLine(typle.Item1);
            Console.WriteLine(typle.Item2);
            Console.WriteLine(typle.Item4);
            Console.WriteLine(typle == typle2);
            (int max, int min, int sum, char sim) localFun(int[] arrayF, string strL)
            {
                int maxS = arrayF.Max();
                int minS = arrayF.Min();
                int sumS = arrayF.Sum();
                char c = strL[0];
                return (maxS, minS, sumS, c);
            }
            var testTuple = localFun(vIntArray, "asdf");
            Console.WriteLine($"min: {testTuple.min}, max: {testTuple.max}, sum: {testTuple.sum}, sim: {testTuple.sim}");

            void local1()
            {
                checked
                {
                    int iMax = int.MaxValue;
                    Console.WriteLine(iMax);
                }
            }
            void local2()
            {
                unchecked
                {
                    int iMax = int.MaxValue;
                    Console.WriteLine(iMax + 1);
                }
            }
            local1(); 
            local2();
        }
    }
}
