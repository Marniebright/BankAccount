using BankAccount;
using System;
using Xunit;

namespace BankAccountTest
{
    public class TestTransaction
    {
        Account account;
        Transaction transaction;
        public TestTransaction()
        {
            this.account = new Account("Marnie", "1234636", "hkd");
            this.transaction = new Transaction(account);
        }

        [Fact]
        public void CheckOverdraftWithdrawal()
        {
            try
            {
                transaction.Withdrawal(500);
            }
            catch(Exception e)
            {
                Assert.Equal("You have exceeded your overdraft limit.", e.Message);
            }
        }

        [Fact]
        public void ChecktWithdrawal()
        {
            transaction.Withdrawal(10);
            Assert.Equal(-10, transaction.GetBalance());
        }
    }
}
