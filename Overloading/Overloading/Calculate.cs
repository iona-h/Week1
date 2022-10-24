using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading
{
    // Calculate inherits Add method from Arithmetic class
    class Calculate : Arithmetic
    {
        //define intial method for float inputs
        public float Add(float a, float b)
        {
            Console.WriteLine("Add floats called");
            return a + b;
        }
        //overload method for string inputs
        public String Add(String a, String b)
        {
            Console.WriteLine("Add strings called");
            return "Hello " + a + " " + b;
        }
    }
}
