using System;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialise instance of class
            Calculate calc = new Calculate();

            //initialise inputs
            int a = 1;
            int b = 2;
            float c = 3.0f;
            float d = 4.0f;
            double e = 5.0d;
            double f = 6.0d;
            String firstName = "Joe";
            String LastName = "Bloggs";

            //call methods
            Console.WriteLine("Add int: {0}", calc.Add(a, b)); //orig from Arithmetic
            Console.WriteLine("Add float: {0}", calc.Add(c, d)); //overload from arithmetic
            Console.WriteLine("Add double: {0}", calc.Add(e, f)); //overload inherited from arithmetic in calculate
            Console.WriteLine("Add string : {0}", calc.Add(firstName, LastName)); //overload inherited from arithmetic in calculate

            Console.ReadLine();
        }
    }
}
