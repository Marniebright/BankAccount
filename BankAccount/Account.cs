using System;
using System.Collections.Generic;

namespace BankAccount
{
    public class Account
    {
        private String _accoutName;
        private String _accountNumber;
        private String _currency;
        private bool _accountStatus;
        public const Decimal _overdraftLimit = -50;

        public Account(string name, string accountNo, string currency)
        {
            this._accoutName = name;
            this._accountNumber = accountNo;
            this._currency = currency;
            
        }
        public String GetAccountName()
        {
            return this._accoutName;
        }
        public String GetAccountNumber()
        {
            return this._accountNumber;
        }
        public String GetCurrency()
        {
            return this._currency;
        }
        public void SetAccountStatus(bool isActive)
        {
            this._accountStatus = isActive;
        }
        public String GetAccountStatus()
        {
            return this._accountStatus ? "Active" : "Inactive";
        }

        public Decimal GetOverdraftLimit()
        {
            return _overdraftLimit;
        }

       
    }
}
