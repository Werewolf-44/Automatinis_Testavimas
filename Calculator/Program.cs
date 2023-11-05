using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 2;

            if (Calculator.Multiply(number1, number2) == 10)
            {
                Console.WriteLine($"Multiplication of {number1} and {number2} works as expected!");
            }
            else
            {
                Console.WriteLine($"Error when multiplying {number1} and {number2}!");
            }
        }
    }
}
