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
        static int generateId()
        {
            return ++id;
        }
        public BankAccount(decimal AccountBalance, BankingTypes AccountType)
        {
            this.AccountBalance = AccountBalance;
            this.AccountType = AccountType;
            this.AccountNumber = generateId();
        }
        public bool Withdraw (decimal _Withdraw , ref decimal AccountBalance)
        {
            decimal Result =  ref this.AccountBalance- _Withdraw;
            if (Result < 0)
                return false ;
            else
                return true ;
        }
        public decimal Deposit (decimal _Deposit  )
        {
            return _Deposit + this.AccountBalance
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            /*long Account_Number = generateID();*/

            Console.WriteLine("Enter Account Balance");
            decimal Account_Balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Type 1 for checking or 2 for Deposit , option : ");
            byte Account_Type = byte.Parse(Console.ReadLine());
            BankAccount b1 = new BankAccount(Account_Balance, (BankingTypes)Account_Type);
            b1.Print();
            Console.WriteLine("How much to withdraw");
            decimal withdrawMony = int.Parse(Console.Read());
            bool result = b1.Withdraw(withdrawMony,Account_Balance) ;
            if (result == true)
                Console.WriteLine("Done successfully ..");
            else
                Console.WriteLine("Your current balance is not enough to withdraw the amount");
            b1.Deposit(40);
            Console.WriteLine(b1.AccountBalance);
            //End Task
            Console.ReadKey();
        }
    }
}
