using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading
{
    class Arithmetic
    {
        //define methods
        //define initial method w int inputs
        public int Add(int a, int b)
        {
            Console.WriteLine("Add ints called");
            return a + b;
        }
        //overload method for double inputs
        public double Add(double a, double b)
        {
            Console.WriteLine("Add doubles called");
            return a + b;
        }
    }
}
