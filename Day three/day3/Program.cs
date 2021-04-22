using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    class Program
    {
        //Task Four
        public int[,] Method()
        {
            int[,] arr = new int[3, 5];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i,j] = 42;
                }
            }
            return arr;
        }
        //End Task
        public static void Parameter (int[,] arr)
        {
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));
        }
        static void Main(string[] args)
        {
            //Task One
            int[] evens =  new int [4];
            for (int i = 0; i < evens.Length ; i++)
            {
                Console.WriteLine("Enter the element ..");
                evens[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < evens.Length; i++)
            {
                Console.WriteLine(evens[i]);
            }
            //End Task

            //Task Two and three
            int crowd = evens[1];
            
            int[] copy = new int[4];
            for (int i = 0; i < evens.Length; i++)
            {
                copy[i] = evens[i];
            }
            for (int i = 0; i < evens.Length; i++)
            {
                Console.WriteLine("the copyed");
                Console.WriteLine(copy[i]);
            }
            //End Task

            //Task Five
            int[,] arr = new int[3, 5];
            Parameter(arr);
            //End Task

            //Task six 
            string[] Names = { "ITI", "Aswan", "Mayar"};
            foreach (string i in Names)
            {
               Console.WriteLine("{0} ", i);
            }
            //End Task
            Console.ReadKey();


        }
    }
}
