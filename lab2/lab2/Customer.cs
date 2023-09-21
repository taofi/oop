using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal partial class Customer
    {
        const int CONST = 0;
        private static int customerCount;
        private readonly uint id;
        private string lastname;
        private string name;
        private string surname;
        private string address;
        private int cardNumber;
        private int balance;

        public uint ID
        {
            get { return id; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string SurName
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
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
            lastname = null;
            name = null;
            surname = null;
            address = null;
            cardNumber = 0;
            balance = 0;
            id = (uint)GetHashCode();
        }
        public Customer(string secondNameF, string nameF, string lastnameF = null, string addressF = null)
        {
            lastname = secondNameF;
            name = nameF;
            surname = lastnameF;
            address = addressF;
            cardNumber = 0;
            balance = 0;
            id = (uint)GetHashCode();
        }
        public Customer(string secondNameF, string nameF, string lastnameF, string addressF, int cardNumberF, int balanceF = 0)
        {
            lastname = secondNameF;
            name = nameF;
            surname = lastnameF;
            address = addressF;
            cardNumber = cardNumberF;
            balance = balanceF;
            id = (uint)GetHashCode();
        }
    }
}
