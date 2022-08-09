using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountUnitTesting
{
   public class BankAccount
    {
        private double balance;
        private string name;
        public BankAccount()
        {
        }

        public BankAccount(string name, double balance)
        {
            this.balance = balance;
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Add(string name, double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            balance += amount;
        }

        public void Withdraw(string name, double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            balance -= amount;
        }

        public void TransferBalance(string name, BankAccount otherAccount, double amount)
        {
            if (otherAccount is null)
            {
                throw new ArgumentNullException(nameof(otherAccount));
            }

            Withdraw(name, amount);
            otherAccount.Add(name, amount);
        }
    }
}
