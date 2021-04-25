using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //first instance
            BankAccount b1 = new BankAccount(1000);
            b1.deposit(50);
            b1.withdraw(180);
            b1.Print();
            //End

            //second instance
            BankAccount b2 = new BankAccount(1200,BankingTypes.checking);
            b2.deposit(130);
            b2.withdraw(400);
            b2.Print();
            //end

            //third instance
            BankAccount b3 = new BankAccount(3000);
            b3.deposit(1000);
            b3.withdraw(980);
            b3.Print();
            //end

            //fourth instance
            BankAccount b4 = new BankAccount(4600, BankingTypes.Deposit);
            b3.deposit(800);
            b3.withdraw(570);
            b3.Print();
            //end
            GC.Collect(0);
            Console.ReadKey();
        }
    }
}
