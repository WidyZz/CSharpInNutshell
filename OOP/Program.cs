using System;
using System.Threading;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAcc = new BankAccount("Vit Chvoj", 28880.52m);
            for (int i = 0; i < 10; i++)
            {
                bankAcc.MakeDeposit((i + 1) * 120.33m, DateTime.UtcNow, $"Random income #{i}");
            }
            for (int i = 0; i < 5; i++)
            {
                bankAcc.MakeWithdrawal((i + 1) * 75.11m, DateTime.UtcNow, $"Random outcome #{i}");
            }
            Console.WriteLine(bankAcc.ShowTransactionsHistory());
            bankAcc.ShowBalance();
        }
    }
}
