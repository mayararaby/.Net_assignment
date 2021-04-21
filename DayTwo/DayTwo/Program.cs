using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
    enum BankingTypes 
    {
        checking = 1,
        Deposit = 2
    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in Enum.GetValues(typeof(BankingTypes)))
            {
                Console.WriteLine($" {i}");
            }
            Console.ReadLine();
        }
    }
}
