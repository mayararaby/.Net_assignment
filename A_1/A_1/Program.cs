using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int hour = 23;
            if (hour >= 0 && hour < 24)
                Console.WriteLine("True");
            else
                hour = 0;
            Console.WriteLine("Enter the hour");
            int hours = int.Parse(Console.ReadLine());
            do
            { 
                if (hours >= 1 && hours <=23)
                {
                    break;
                }
                Console.WriteLine("Enter the hour");
                hours = int.Parse(Console.ReadLine());
            } while ( hours>=
            0);
            Console.ReadLine();
        }
    }
}
