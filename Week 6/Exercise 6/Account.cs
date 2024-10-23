using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Account
    {
        private string _accountHolder;
        private double _amount;

        public Account(string accountHolder)
        {
            _accountHolder = accountHolder;
            _amount = 0; // Initialize amount to 0
        }

        public void Deposit(double amount)
        {
            if (amount > 0) 
            {
                _amount = _amount + amount;
                LogTransaction($"Deposited: ${amount}"); // Log the transaction
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        void LogTransaction(string message)
        {
            Console.WriteLine($"Transaction Log: {message}");
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {_accountHolder}");
            Console.WriteLine($"Account Balance: ${_amount}");
        }
    }
}
