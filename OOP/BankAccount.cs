using System;
using System.Collections.Generic;
using System.Text;
using static OOP.Transaction;

namespace OOP
{
    public class BankAccount
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                allTransactions.ForEach(x => balance += x.Amount);
                return balance;
            }
        }
        private List<Transaction> allTransactions = new List<Transaction>();
        public BankAccount(string name, decimal initialBalance)
        {
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

            this.Number = Guid.NewGuid().ToString();
            this.Name = name;
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Cannot deposit non-positive amount");

            allTransactions.Add(new Transaction(TransactionType.Deposit, amount, date, note));
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0 && this.Balance < amount)
                throw new ArgumentOutOfRangeException(nameof(amount), "Could not withdraw given amount!");

            allTransactions.Add(new Transaction(TransactionType.Withdraw, amount, date, note)); ;
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Balance of Account no. {this.Number} = {this.Balance}.");
        }
        public string ShowTransactionsHistory()
        {
            var a = new StringBuilder();
            a.AppendLine("Date\t\tType\t\tAmount\t\tNote");
            allTransactions.ForEach(x =>
            {
                if(x.Type == TransactionType.Withdraw)
                    a.AppendLine($"{x.Date.ToShortDateString()}\t{x.Type}\t{x.Amount:C2}\t{x.Note}");
                else
                    a.AppendLine($"{x.Date.ToShortDateString()}\t{x.Type}\t\t{x.Amount:C2}\t{x.Note}");
            });
            return a.ToString();
        }
    }
}
