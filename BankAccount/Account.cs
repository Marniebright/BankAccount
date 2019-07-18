using System;
using System.Collections.Generic;

namespace BankAccount
{
    public class Account
    {
        private String accoutName;
        private String accountNumber;
        private String currency;
        private bool accountStatus;
        private Transactions transactions;
      
        public Account(string name, string accountNo, string currency, Transactions transactions)
        {
            this.accoutName = name;
            this.accountNumber = accountNo;
            this.currency = currency;
            this.transactions = transactions;
        }
        public String GetAccountName()
        {
            return this.accoutName;
        }
        public String GetAccountNumber()
        {
            return this.accountNumber;
        }
        public String GetCurrency()
        {
            return this.currency;
        }
        public void SetAccountStatus(bool isActive)
        {
            this.accountStatus = isActive;
        }
        public String GetAccountStatus()
        {
            return this.accountStatus ? "Active" : "Inactive";
        }

        public String DisplayAccountDetails()
        {
            string details = "Account Number: " + GetAccountNumber() + "\n" +
                             "Account Name: " + GetAccountName() + "\n" +
                             "Currency: " + GetCurrency() + "\n" +
                             "Status: " + GetAccountStatus() + "\n" +
                             "Balance: " + transactions.GetBalance() + "\n" +
                             "Has Exceeded Overdraft: " + transactions.GetOverdraftStatus();
                             
            return details;
        }

        public Transactions GetTransactions()
        {
            return this.transactions;
        }
    }
}
