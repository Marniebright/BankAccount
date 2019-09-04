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
        public const Decimal overdraftLimit = -50;

        public Account(string name, string accountNo, string currency)
        {
            this.accoutName = name;
            this.accountNumber = accountNo;
            this.currency = currency;
            
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

        public Decimal GetOverdraftLimit()
        {
            return overdraftLimit;
        }

       
    }
}
