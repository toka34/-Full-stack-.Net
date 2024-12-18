using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    public struct Account
    {
        // Private attributes
        private int accountId;
        private string accountHolder;
        private decimal balance;

        // Public properties for accessing private attributes
        public int AccountId
        {
            get { return accountId; }
            private set { accountId = value; }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            private set { accountHolder = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        // Constructor to initialize the Account struct
        public Account(int id, string holder, decimal initialBalance)
        {
            accountId = id;
            accountHolder = holder;
            balance = initialBalance;
        }

        // Method to deposit money
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method to withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount:C}. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
    }
}
