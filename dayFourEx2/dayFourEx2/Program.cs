using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayFourEx2
{
    enum BankingTypes : byte
    {
        checking = 1,
        Deposit = 2
    }
    class BankAccount
    {
        private static int id = 1;
        public long AccountNumber { get; set ; }
        public decimal AccountBalance { get; set; }
        public BankingTypes AccountType { get; set; }
        public void Print()
        {
            Console.WriteLine(
                $"Account Number = {this.AccountNumber}, " +
                $"Account Type = {this.AccountType}, " +
                $"Account Balance = {this.AccountBalance}");
        }
        public int generateId()
        {
            return ++id;
        }
        public BankAccount(decimal AccountBalance, BankingTypes AccountType)
        {
            this.AccountBalance = AccountBalance;
            this.AccountType = AccountType;
            this.AccountNumber = generateId();
        }
       
        public bool withdraw(decimal outAmt)
        {
            bool chk = true;
            if (outAmt <= this.AccountBalance)
            {
                this.AccountBalance -= outAmt;
            }
            else if (outAmt > this.AccountBalance)
            {
                chk = false;
            }
            return chk;
        }
        public void deposit(decimal addAmt)
        {
            this.AccountBalance += addAmt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //List<BankAccount> bank = new List<BankAccount>();
            Console.Write("Enter initial balance: ");
            decimal init = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Type 1 for checking or 2 for Deposit , option : ");
            byte Account_Type = byte.Parse(Console.ReadLine());
            BankAccount b1 = new BankAccount(init, (BankingTypes)Account_Type);
            b1.Print();
            Console.WriteLine("Bank Account Added!");
            Console.Write("Amount to Deposit: ");
            b1.deposit(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("Amount successfully deposited!");
            Console.Write("Amount to Withdraw: ");
            bool result = b1.withdraw(decimal.Parse(Console.ReadLine()));

            if (result == true)
                Console.WriteLine("Amount successfully withdrawn!");
            else
                Console.WriteLine("Your current balance is not allowed");
            //End Task
            
            Console.ReadKey();
        }
    }
}
