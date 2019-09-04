using BankAccount;
using Xunit;

namespace BankAccountTest
{
    public class TestAccount
    {
        Account account = new Account("Marnie", "M12444", "HKD");

        [Fact]
        public void GetAccountName()
        {
            //Assert.Equal(expected, actual)
            Assert.Equal("Marnie", account.GetAccountName());
        }

        [Fact]
        public void GetAccountNumber()
        {
            Assert.Equal("M12444", account.GetAccountNumber());
        }

        [Fact]
        public void GetAccountCurrency()
        {
            Assert.Equal("HKD", account.GetCurrency());
        }

        [Fact]
        public void CheckActiveAccount()
        {
            account.SetAccountStatus(true);
            Assert.Equal("Active", account.GetAccountStatus());
        }

        [Fact]
        public void CheckInactiveAccount()
        {
            account.SetAccountStatus(false);
            Assert.Equal("Inactive", account.GetAccountStatus());
        }

        [Fact]
        public void CheckOverdraft()
        {
            Assert.Equal(-50, account.GetOverdraftLimit());
        }
    }
}
