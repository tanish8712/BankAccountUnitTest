using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tBankAccountUnitTesting");
            var acc = new BankAccount("Rajveer", 5000);
            Console.WriteLine("Account Holder Name : {0}", acc.Name);
            Console.Write("Amount: ");
            Console.WriteLine(acc.Balance);
            acc.Add("Rajveer", 500);
            Console.Write("\nUpdated Amount: ");
            Console.WriteLine(acc.Balance);
            Console.ReadLine();
        }
    }
}
