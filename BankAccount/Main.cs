using System;

namespace BankAccount
{
    public class MainMenu
    {
        public static void Main(string[] args)
        {
            Account account = new Account("Marnie", "M1187980", "HKD", new Transactions());
           
            account.SetAccountStatus(true);
            account.GetTransactions().DepositFunds(100);
            account.GetTransactions().WithdrawFunds(100);
            account.GetTransactions().SetOverdraft(50);
           

            Console.WriteLine(account.DisplayAccountDetails());

        }
    }
}
