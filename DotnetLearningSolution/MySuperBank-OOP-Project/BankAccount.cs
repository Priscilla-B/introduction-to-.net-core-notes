﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            } }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        // constructor for BankAccount.
        // can use the same class name since it's a constructor
        // has no return type (e.g. "void") to distinguish it from
        // regular class methods
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            // requirement says bank account cannot be created with a zero or less balance

            this.Number = accountNumberSeed.ToString();
            // can do without the "this" keyword
            accountNumberSeed++;
           
        }
        
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");

            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            // header
            report.AppendLine("Date\t\tAmount\tNote");

            foreach (var transaction in allTransactions)
            {
                // rows
                report.AppendLine($"" +
                    $"{transaction.Date.ToShortDateString()}" +
                    $"\t{transaction.Amount}" +
                    $"\t{transaction.Notes}");
            }

            return report.ToString();
        }
    }
}
