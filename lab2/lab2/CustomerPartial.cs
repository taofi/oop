using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal partial class Customer
    {
        public static bool operator >(Customer cust1, Customer cust2)
        {
            return string.Compare(cust1.LastName, cust2.LastName) > 0;
        }
        public static bool operator <(Customer cust1, Customer cust2)
        {
            return string.Compare(cust1.LastName, cust2.LastName) < 0;
        }
        public override bool Equals(object obj)
        {
            if (obj is Customer otherCustomer)
            {
                return LastName == otherCustomer.LastName
                    && SurName == otherCustomer.SurName
                    && Name == otherCustomer.Name
                    && Address == otherCustomer.Address;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Фамилия: {lastname}, Имя: {name}, Отчество: {surname}\n Адресс: {address}. Номер карточки:{cardNumber} , Баланс:{balance}, ID: {id} ";
        }
        public override int GetHashCode()
        {
            customerCount++;
            return (customerCount.ToString(), name, lastname, surname).GetHashCode();
        }
    }
}
