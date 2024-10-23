using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    internal class BankAccount
    {
        private string _accountNumber;
        private double _balance;

        public BankAccount(string accountNumber, double initialBalance)
        {
            _accountNumber = accountNumber;
            _balance = initialBalance;
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance = _balance + amount;
                Console.WriteLine("Deposive was successful.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance = _balance - amount;
            }
            else
            {
                Console.WriteLine("Enter a valid amount.");
            }
        }
    }
}
