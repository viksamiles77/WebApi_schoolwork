using Qinshift.Services;

namespace Qinshift.xUnitTests
{
    public class BankAccountTests
    {
        private BankAccount _bankAccount;
        public BankAccountTests()
        {
            _bankAccount = new BankAccount(1000);
        }

        [Fact]
        public void BankAccount_AddAmountGreaterThanZero_ShouldIncreaseBalance()
        {
            // 1. Arrange

            // 2. Act
            _bankAccount.Add(500);
            // 3. Assert
            Assert.Equal(1500, _bankAccount.Balance);
        }

        [Fact]
        public void BankAccount_AddNegativeAmount_ShouldThrowException()
        {
            // 1. Arrange

            // 2. Act + Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.Add(-500));
        }

        [Fact]
        public void BankAccount_WithdrawAmountLessThanBalance_ShouldDecreaseBalance()
        {

            _bankAccount.Withdraw(300);

            Assert.Equal(700, _bankAccount.Balance);
        }

        [Fact]
        public void BankAccount_WithdrawAmountLessThanZero_ShouldThrowArgumentNotFoundException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.Withdraw(-200));
        }

        [Fact]
        public void BankAccount_WithdrawAmountGreaterThanBalance_ShouldThrowArgumentNotFoundException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.Withdraw(1200));
        }

        [Fact]
        public void BankAccount_TransferFundsToOtherExistingAccount_ShouldIncreaseOtherAccountsBalance()
        {
            var otherAccount = new BankAccount();

            _bankAccount.TransferFoundsTo(otherAccount, 700);

            Assert.Equal(300, _bankAccount.Balance);
            Assert.Equal(700, otherAccount.Balance);
        }

        [Fact]
        public void _bankAccount_TransferFundsToOtherNullAccount_ShouldThrowArgumentNullException()
        {

            Assert.Throws<ArgumentNullException>(() => _bankAccount.TransferFoundsTo(null, 500));
        }
    }
}