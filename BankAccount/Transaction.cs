using System;

namespace BankAccount
{
    public class Transaction
    {
        private Decimal _deposit;
        private Decimal _withdrawal;
        private Account _account;
        private Decimal _balance;

        public Transaction(Account account)
        {
            this._account = account;
        }

        public void Withdrawal(Decimal withdrawal)
        {
            if (this.HasExceededOverdraft(withdrawal))
            {
                throw new Exception("You have exceeded your overdraft limit");
            }
            
            this._balance -= withdrawal;
        }
        public void Deposit(Decimal deposit)
        {
            this._balance += deposit;
        }

        public Decimal GetDeposit()
        {
            return this._deposit;
        }

        public Decimal GetWithdrawal()
        {
            return this._withdrawal;
        }
        public Boolean HasExceededOverdraft(Decimal withdrawal)
        {
            // 0 <= -50
            if (GetBalance() - withdrawal <= _account.GetOverdraftLimit())
            {
               return true;
            }

            return false;
        }

        public Decimal GetBalance()
        {
            return _balance;
        }
    }
}
