using System;

namespace BankAccount
{
    public class Transaction
    {
        private Decimal deposit;
        private Decimal withdrawal;
        private Account account;
        private Decimal balance;

        public Transaction(Account account)
        {
            this.account = account;
        }

        public void Withdrawal(Decimal withdrawal)
        {
            if (this.HasExceededOverdraft(withdrawal))
            {
                throw new Exception("You have exceeded your overdraft limit");
            }
            
            this.balance -= withdrawal;
        }
        public void Deposit(Decimal deposit)
        {
            this.balance += deposit;
        }
        public Decimal GetDeposit()
        {
            return this.deposit;
        }

        public Decimal GetWithdrawal()
        {
            return this.withdrawal;
        }
        
        public Boolean HasExceededOverdraft(Decimal withdrawal)
        {
            // 0 <= -50
            if (GetBalance() - withdrawal <= account.GetOverdraftLimit())
            {
               return true;
            }

            return false;
        }

        public Decimal GetBalance()
        {
            return balance;
        }
    }
}
