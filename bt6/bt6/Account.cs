using System;
using System.Collections.Generic;
using System.Text;

namespace bt6
{
    class Account
    {
        private int accountNumber;
        private string name;
        private double balance;
        private const double rate = 0.035;

        public Account(int accountNumber, string name, double balance)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = balance;
        }
        public Account()
        {
            accountNumber = 999999;
            name = "chua xac dinh";
            balance = 50000;

        }
        public Account(int accountNumber, string name)
        {
            AccountNumber = accountNumber;
            Name = name;
        }
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }
        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return true;
            }
            else return false;
        }
        public bool Withdraw (double amount, double fee)
        {
            if (amount > 0 && amount + fee <= balance)
            {
                balance -= amount + fee;
                return true;
            }
            else return false;
        }
        
    }
}
