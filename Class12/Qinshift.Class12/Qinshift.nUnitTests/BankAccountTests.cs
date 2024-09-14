using Qinshift.Services;

namespace Qinshift.nUnitTests
{
    public class Tests
    {
        private BankAccount _bankAccount;
        [SetUp]
        public void Setup()
        {
            _bankAccount = new BankAccount(1000);
        }

        [Test]
        public void BankAccount_AddAmountGreaterThanZero_ShouldIncreaseBalance()
        {
            // 1. Arrange

            // 2. Act
            _bankAccount.Add(500);
            // 3. Assert
            Assert.AreEqual(1500, _bankAccount.Balance);
        }

        [Test]
        public void BankAccount_AddNegativeAmount_ShouldThrowException()
        {
            // 1. Arrange

            // 2. Act + Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.Add(-500));
        }

        [Test]
        public void BankAccount_WithdrawAmountLessThanBalance_ShouldDecreaseBalance()
        {

            _bankAccount.Withdraw(300);

            Assert.AreEqual(700, _bankAccount.Balance);
        }

        [Test]
        public void BankAccount_WithdrawAmountLessThanZero_ShouldThrowArgumentNotFoundException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.Withdraw(-200));
        }

        [Test]
        public void BankAccount_WithdrawAmountGreaterThanBalance_ShouldThrowArgumentNotFoundException()
        {

            Assert.Throws<ArgumentOutOfRangeException>(() => _bankAccount.Withdraw(1200));
        }

        [Test]
        public void BankAccount_TransferFundsToOtherExistingAccount_ShouldIncreaseOtherAccountsBalance()
        {
            var otherAccount = new BankAccount();

            _bankAccount.TransferFoundsTo(otherAccount, 700);

            Assert.AreEqual(300, _bankAccount.Balance);
            Assert.AreEqual(700, otherAccount.Balance);
        }

        [Test]
        public void _bankAccount_TransferFundsToOtherNullAccount_ShouldThrowArgumentNullException()
        {

            Assert.Throws<ArgumentNullException>(() => _bankAccount.TransferFoundsTo(null, 500));
        }
    }
}