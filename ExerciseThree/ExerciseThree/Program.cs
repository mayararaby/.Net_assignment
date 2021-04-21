using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseThree
{
    enum BankingTypes 
    {
        checking = 1,
        Deposit = 2
    }
    struct BankAccount
    {
        public long AccountNumber;
        public decimal AccountBalance;
        public BankingTypes AccountType;
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
            BankAccount firstInstance;
            Console.WriteLine("Enter Account Balance ");
            firstInstance.AccountBalance = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Account Number ");
            firstInstance.AccountNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Number Of Account Type");
            Console.WriteLine($"1- checking \n" +
                $"2- Deposit "
               );
            int option = int.Parse((Console.ReadLine()));
            if (option == 1)
            {
                firstInstance.AccountType = BankingTypes.checking;
            }
            else if (option == 2)
            {
                firstInstance.AccountType = BankingTypes.Deposit;
            }
            firstInstance.Print(); 
            Console.ReadLine();
        }
    }
}
