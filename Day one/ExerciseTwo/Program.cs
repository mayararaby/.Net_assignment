using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
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

        public override string ToString()
        {
            return $"Account Balance = {AccountBalance}, Account Number =" +
             $"{AccountNumber}, Account Type = {AccountType}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in Enum.GetValues(typeof(BankingTypes)))
            {
                Console.WriteLine($" {i}");
            }
            BankAccount firstInstance;
            firstInstance.AccountBalance = 2000;
            firstInstance.AccountNumber = 12374645198;
            firstInstance.AccountType = BankingTypes.checking;
            Console.WriteLine(firstInstance.ToString());
            Console.ReadLine();
        }
    }
}
