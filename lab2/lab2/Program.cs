using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customerEmpty = new Customer();
            Customer customerOnlyFI = new Customer("Петров", "Гордей");
            Customer customerAll = new Customer("Королёв", "Андрей", "Фролович", "просп. Победителей, 13", 1234567890);
            Console.WriteLine(customerAll.ToString());
            Console.WriteLine(customerEmpty.ToString());
            Console.WriteLine(customerOnlyFI.ToString());
            Console.WriteLine(customerAll.ToString());
            customerAll.AddBalance(123);
            Console.WriteLine(customerAll.ToString());
            customerAll.WriteOffBalance(23);
            Customer[] arrayObj = new Customer[] { new Customer("Куликов", "Болеслав", "Даниилович", "Кальварийская ул., 24", 127890),
                                                   new Customer("Князев", "Всеволод", "Глебович", "ул. Дунина-Марцинкевича, 11", 67890),
                                                   new Customer("Соколов", "Лазарь", "Вадимович", "ул. Немига, 3", 12390),
                                                   new Customer("Прохоров", "Агафон", "Робертович", "ул. Мельникайте, 13", 12890),
                                                   new Customer("Котова", "Дина", "Протасьевна", "просп. Дзержинского, 10", 890),
                                                   new Customer("Меркушева", "Луиза", "Антоновна", " ул. Мясникова, 34", 7890),
                                                   new Customer("Королёв", "Андрей", "Фролович", "просп. Победителей, 13", 7890),
                                                   new Customer("Воробьёва", "Николь", "Юлиановна", "ул. Карла Либкнехта, 32", 4567890),
                                                   customerAll, customerOnlyFI};
            Console.WriteLine();
            for (int i = 1; i < arrayObj.Length; i ++)
            {
                for (int j = 0; j < arrayObj.Length - i ; j++)
                {
                    if (arrayObj[j] > arrayObj[j + 1])
                    {
                        Customer temp = arrayObj[j];
                        arrayObj[j] = arrayObj[j + 1];
                        arrayObj[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arrayObj.Length; i++)
            {
                Console.WriteLine(arrayObj[i].ToString());
            }
            Console.WriteLine("\nВведите промежуток номеров кредитных карточек");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < arrayObj.Length; i++)
            {
                if(arrayObj[i].CardNumber >= a && arrayObj[i].CardNumber <= b)
                    Console.WriteLine(arrayObj[i].ToString());
            }
            var anonim = new {LastName = "Прохоров", Name = "Агафон", Surname = "Робертович"};
            Console.WriteLine($"Фамилия: {anonim.LastName} Имя: {anonim.Name} Отчество: {anonim.Surname}");
        }
    }
}
