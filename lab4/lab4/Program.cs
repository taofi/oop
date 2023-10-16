using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlowerBouquetController controller = new FlowerBouquetController();
            int cost = -32;
            int count = -5;
            try
            {
                Flower a = new Flower("rose", "red", cost, count);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
                cost *= -1;
            }
            finally
            { Console.WriteLine(); }
            try
            {
                Flower a = new Flower("rose", "red", cost, count);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                count *= -1;
            }
            finally
            { Console.WriteLine(); }
            try 
            {
                Flower f = new Flower("rose", "red", 32, 5);
                try
                {
                    f.CostChange(-9);
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
            catch (Exception ex) { Debug.Fail(ex.ToString()); }
            finally
            { Console.WriteLine();}

            try
            {
                Flower a = new Flower("rose123", "red", cost, count);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally
            { Console.WriteLine(); }

            int[] arr = { 1, 2, 3, 4, 5 }; // массив размером 5
            try
            {
                var length = 10;
                Debug.Assert(length < arr.Length, "Выход за рамки массива");
                Debugger.Break();
               // Console.WriteLine("asd");
                if (length > arr.Length) throw new IndexOutOfRangeException("эта длина превышает размер массива");
                for (var i = 0; i < length; i++)
                    arr[i] += arr[i];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("\n\tError");
                Console.WriteLine($"Сообщение об ошибке: {ex.Message}");
                Console.WriteLine("Расположение: {0}", ex.TargetSite);
                try
                {
                    Console.WriteLine("Обработка внутреннего исключения IndexOutOfRangeException");
                    throw ex; // проброс исключения выше по стеку вызовов.
                }
                catch (IndexOutOfRangeException innerEx)
                {
                    Console.WriteLine("Внутреннее исключение: " + innerEx.Message);

                }
            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }
        }
    }
}
