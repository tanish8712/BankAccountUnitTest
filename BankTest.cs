using BankAccountUnitTesting;
using NUnit.Framework;
using System;

namespace BankUnitTest
{
    public class BankTest
    {
        [Test]
        public void Adding_balance()
        {
            var account = new BankAccount("Ram", 5000);
            account.Add("Ram", 1000);
            Assert.That(account.Balance, Is.EqualTo(6000));
        }
        [Test]
        public void Adding_negative_balance()
        {
            var account = new BankAccount("Mike", 1000);
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Add("Mike", -500));
        }
        [Test]
        public void Withdraw_balance()
        {
            var account = new BankAccount("John",4500);
            account.Withdraw("John", 500);
            Assert.That(account.Balance, Is.EqualTo(4000));
        }
        [Test]
        public void Withdrawing_negative_balance()
        {
            var account = new BankAccount("Raj", 2000);
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw("Raj", -500));
        }
        [Test]
        public void Withdrawing_More_balance()
        {
            var account = new BankAccount("John", 500);
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw("John", 900));
        }
        [Test]
        public void Transfer()
        {
            var account = new BankAccount("Raj", 400);
            var otheraccount = new BankAccount();
            account.TransferBalance("Ram", otheraccount, 200);
            Assert.That(account.Balance, Is.EqualTo(200));
            Assert.That(otheraccount.Balance, Is.EqualTo(200));
        }
        [Test]
        public void Non_exit_account()
        {
            var account = new BankAccount("Sandeep", 1000);
            Assert.Throws<ArgumentNullException>(() => account.TransferBalance("Sandeep", null, 200));
        }
    }
}
