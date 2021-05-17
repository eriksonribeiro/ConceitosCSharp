using BankAccountExceptions.Entities.Domain;
using System;

namespace BankAccountExceptions.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException($"Withdraw Error: The amount exceeds withdraw limit! Withdraw: ${amount:f2} Withdraw Limit: ${WithdrawLimit:f2}"); 
            }
            if (amount > Balance)
            {
                throw new DomainException($"Withdraw Error: Not enough balance! Withdraw: ${amount:f2} Balance: ${Balance:f2}");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account Number: {Number}\nHolder: {Holder}\nBalance: ${Balance:f2}";
        }
    }
}
