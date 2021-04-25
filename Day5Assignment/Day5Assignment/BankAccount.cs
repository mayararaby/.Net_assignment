using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Day5Assignment
{
    enum BankingTypes : byte
    {
        checking = 1,
        Deposit = 2
    }
    class BankAccount
    {
        private static int id = 1;
        public long AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public BankingTypes AccountType { get; set; }
        private List<BankTransaction> Transaction;
        public BankAccount()
            : this (0, BankingTypes.checking)
        {
        }
        public BankAccount(BankingTypes AccountType)
            : this(0,AccountType)
        {
        }
        public BankAccount(decimal AccountBalance )
            : this(AccountBalance , BankingTypes.checking)
        { 
        }
        public BankAccount(decimal AccountBalance , BankingTypes AccountType)
        {
            this.AccountBalance = AccountBalance;
            this.AccountType = (BankingTypes)AccountType;
            this.AccountNumber = ++id;
            Transaction = new List<BankTransaction>();
        }
        public bool withdraw(decimal outAmt)
        {
            bool chk = false;
            if (outAmt > this.AccountBalance)
                return false;  
            else
            {
                this.AccountBalance -= outAmt;
                chk = true;
                BankTransaction Instance = new BankTransaction((outAmt * -1));
                Transaction.Add(Instance);
            }
            return chk;
        }
        public void deposit(decimal addAmt)
        {
            this.AccountBalance += addAmt;
            BankTransaction Instance = new BankTransaction(addAmt);
            Transaction.Add(Instance);
        }

        public void Print()
        {
            Console.WriteLine(
                $"Account Number = {this.AccountNumber}, " +
                $"Account Type = {this.AccountType}, " +
                $"Account Balance = {this.AccountBalance}");
        }

        ~BankAccount()
        {
            using (StreamWriter writer = new StreamWriter("detalis.txt"))
            {
                foreach (BankTransaction T in Transaction)
                {
                    //writer.WriteLine("Hi");
                    writer.WriteLine("The Amount is : " + T.Amont + " The Date is : " + T.day);
                }
            }

        }
    }
}
