using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int n = 5;
            var monthsWithLengthN = months.Where(month => month.Length == n);
            foreach (var month in monthsWithLengthN) { Console.Write($"{month} "); }; Console.WriteLine();
            var sw = months.Where(month => month.ToLower() == "december" || month.ToLower()  == "january" || month.ToLower()  == "february" || month.ToLower() == "june" || month.ToLower() == "july" || month.ToLower() == "august");
            foreach (var month in sw) { Console.Write($"{month} "); }; Console.WriteLine();
            var monthsSorted= months.OrderBy(month => month);
            foreach (var month in monthsSorted) { Console.Write($"{month} "); }; Console.WriteLine();
            var monthsWithU = months.Where(month => month.Contains("u") && month.Length >= 4).Count();
            Console.WriteLine(monthsWithU);

            List<Customer> list = new List<Customer>();
            list.Add(new Customer("asfs", 1245, 90));
            list.Add(new Customer("asfs", 7455, 670));
            list.Add(new Customer("asfs", 2345, 240));
            list.Add(new Customer("jfsdsfs", 9021, 3000));
            list.Add(new Customer("hkvsdsfs", 5734, 20));
            list.Add(new Customer("ghdfs", 5017, 100));
            list.Add(new Customer("ye5tdbasfs", 1351, 80));
            list.Add(new Customer("asfs", 8245, 90));
            list.Add(new Customer("casfs", 1245, 9990));
            list = list.OrderBy(Customer => Customer.Name).ToList();
            foreach(var customer in list) { Console.WriteLine(customer.ToString()); }; Console.WriteLine();
            var cardN = list.Where(Customer => Customer.CardNumber >= 2000 && Customer.CardNumber <= 7000);
            foreach (var customer in cardN) { Console.WriteLine(customer.ToString()); }; Console.WriteLine();
            var maxNumber = list.Max(Customer => Customer.CardNumber);
            Console.WriteLine(maxNumber.ToString());
            Console.WriteLine();
            var topFive = list.OrderByDescending(customer => customer.Balance).Take(5).ToList();
            foreach (var customer in topFive) { Console.WriteLine(customer.ToString()); }; Console.WriteLine();

            var queryResult = list
            .Where(customer => customer.Balance > 500)
            .OrderByDescending(customer => customer.Balance) 
            .GroupBy(customer => customer.Name.Length) // Группировка: группируем клиентов по длине имени
            .Select(group => new
            {
                NameLength = group.Key,
                TotalBalance = group.Sum(customer => customer.Balance),
                AverageNumber = group.Average(customer => customer.CardNumber) 
            })
            .Where(result => result.TotalBalance > 200) // Условие: выбираем группы с общим балансом более 1000
            .Take(2); // Квантор: берем первые две группы
            foreach (var result in queryResult)
            {
                Console.WriteLine($"Name Length: {result.NameLength}, Total Balance: {result.TotalBalance}, Average Number: {result.AverageNumber}");
            }
            List<Customer> list2 = new List<Customer>();
            list2.Add(new Customer("jfsdsfs", 9021, 3600));
            list2.Add(new Customer("hkvsdsfs", 5734, 800));
            list2.Add(new Customer("ghdfs", 5017, 200));
            list2.Add(new Customer("ye5tdbasfs", 1351, 900));
            list2.Add(new Customer("ye5tdbkjkfahsbasfs", 1351, 900));
            var joinResult = from customer2 in list2
                             join customer1 in list
                             on customer2.Name equals customer1.Name
                             select new
                             {
                                 Name = customer1.Name,
                                 Balance = customer1.Balance + customer2.Balance,
                             };
            foreach(var result in joinResult) 
            {
                Console.WriteLine($"{result.Name} {result.Balance}");
            }
        }
    }
}
