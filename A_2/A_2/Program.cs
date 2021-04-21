using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_2
{
    public struct Utils
    {
        public int Greater(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
                return firstNumber;
            else
                return secondNumber;
        }
        public void Swap(ref int firstNumber, ref int secondNumber)
        {
            int temp;
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine( $"first Number {firstNumber}, " +
                $"second Number = {secondNumber}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Utils u1;
            Console.WriteLine($"The great value is {u1.Greater(40, 50)}" );
            int instanceOne = 20; 
            int instanceTwo = 30;
             u1.Swap(ref instanceOne , ref instanceTwo);
            Console.ReadLine();
        }
    }
}
