using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        public TransactionType Type { get; set; }

        public Transaction(TransactionType type, decimal amount, DateTime date, string note)
        {
            this.Type = type;
            this.Date = date;
            this.Note = note;

            if (type == TransactionType.Deposit)
                this.Amount = amount;
            else
                this.Amount -= amount;
        }
        public enum TransactionType
        {
            Deposit,
            Withdraw
        }
    }
}
