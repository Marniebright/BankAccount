using System;

namespace BankAccount
{
    public class Main
    {
        public static void Main(string[] args)
        {
            Account account = new Account("Marnie", "S12345678", "HKD");
            account.SetAccountStatus(true);

            Console.WriteLine( "Account Number: " + account.GetAccountNumber() + "\n" +
                                "Account Name: " + account.GetAccountName() + "\n" +
                                "Currency: " + account.GetCurrency() + "\n" +
                                "Status: " + account.GetAccountStatus() + "\n");

            Transaction transaction = new Transaction(account);
            transaction.Withdrawal(49);

            Console.WriteLine("Balance is " + transaction.GetBalance().ToString());

        }
    }
}
