using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Calculator
    {
        //public method: addition
        public int Add(int a, int b)
        {
            return a + b;
        }

        //public method: subtraction
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        //public method: multiplication
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        //public method: division
        public decimal Divide(int a, int b)
        {
            return Decimal.Round(a / b, 2);
        }

    }
}
