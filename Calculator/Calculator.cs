﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        static internal int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        static internal int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        static internal int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static internal double Divide(int number1, int number2)
        {
            return (double)number1 / number2;
        }
    }
}
