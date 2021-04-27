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
            b1.deposit(60);
            b1.withdraw(180);
            b1.Print();
            //End

            //second instance
            BankAccount b2 = new BankAccount(1000,BankingTypes.checking);
            b2.deposit(50);
            b2.withdraw(180);
            b2.Print();
            //end

            Console.WriteLine(b1.Equals(b2));
            Console.WriteLine(b1==b2);
            Console.WriteLine(b1!=b2);
            Console.WriteLine(b1.ToString());

            GC.Collect(0);
            Console.ReadKey();
        }
    }
}
