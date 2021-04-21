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
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the hour");
                hours = int.Parse(Console.ReadLine());
                if (hours >= 1 && hours <= 23)
                    break;
            }
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
