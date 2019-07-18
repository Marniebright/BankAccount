using System;

namespace BankAccount
{
    public class Transactions
    {
        private Decimal deposit;
        private Decimal withdrawal;
        private Decimal overdraft;
        private Decimal balance;

        public void DepositFunds(decimal deposit)
        {
            this.deposit += deposit;
        }

        public void WithdrawFunds(decimal withdrawal)
        {
            this.withdrawal += withdrawal;
        }

        public void SetOverdraft(decimal overdraft)
        {
            this.overdraft = -overdraft;
        }

        public String GetOverdraftStatus()
        {
            bool overdraft = false;

            if (GetBalance() < this.overdraft)
            {
                overdraft = true;
            }

            return overdraft ? "Yes" : "No";
        }

        public Decimal GetBalance()
        {
            this.balance = this.deposit - this.withdrawal;
            return balance;
        }
    }
}
