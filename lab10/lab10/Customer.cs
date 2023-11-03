using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Customer
    {
        const int CONST = 0;
        private static int customerCount;
        private readonly uint id;
        private string name;
        private int cardNumber;
        private int balance;

        public uint ID
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int CardNumber
        {
            get { return cardNumber; }
        }
        public int Balance
        {
            get { return balance; }
        }
        public void AddBalance(int amount)
        {
            balance += amount;
        }
        public bool WriteOffBalance(int amount)
        {
            if (balance < amount)
                return false;
            else
                balance -= amount;
            return true;
        }
        public static int GetCustomerCount()
        {
            return customerCount;
        }
        static Customer()
        {
            customerCount = 0;
        }
        public Customer()
        {
            name = null;
            cardNumber = 0;
            balance = 0;
            id = (uint)GetHashCode();
        }
        public Customer(string nameF,  int cardNumberF, int balanceF = 0)
        {
            name = nameF;
            cardNumber = cardNumberF;
            balance = balanceF;
        }
        public override string ToString()
        {
            return $"{name} {cardNumber} {balance}";
        }
    }
}
