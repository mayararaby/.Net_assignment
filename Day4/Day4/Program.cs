using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    enum BankingTypes :byte
    {
        checking = 1,
        Deposit = 2
    }
    class BankAccount
    {
        public long AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public BankingTypes AccountType { get; set; }
        public void Print()
        {
            Console.WriteLine(
                $"Account Number {this.AccountNumber}, " +
                $"Account Type {this.AccountType}, " +
                $"Account Balance = {this.AccountBalance}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Task One
            Console.WriteLine("Enter Account Number");
            long Account_Number = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Balance");
            decimal Account_Balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Type 1 for checking or 2 for Deposit , option : ");
            byte Account_Type = byte.Parse(Console.ReadLine());
            BankAccount b1 = new BankAccount()
            {
                AccountNumber = Account_Number ,
                AccountBalance = Account_Balance,
                AccountType = Account_Type
            };
            b1.Print();
            //End Task
            Console.ReadKey();
        }
    }
}
