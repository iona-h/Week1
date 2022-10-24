using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the class and creta an object
            Calculator calc = new Calculator();

            //Create a local variable to hold the answer
            int x = 3;
            int y = 5;
            int sum = 0;
            int sub = 0;
            int product = 0;
            decimal fraction = 0;

            //call methods of calculator class
            sum = calc.Add(x, y);
            sub = calc.Subtract(x, y);
            product = calc.Multiply(x, y);
            fraction = calc.Divide(x, y);

            //print
            Console.WriteLine("sum of the {0} + {1} = {2}", x, y, sum);
            Console.WriteLine("sum of the {0} - {1} = {2}", x, y, sub);
            Console.WriteLine("sum of the {0} x {1} = {2}", x, y, product);
            Console.WriteLine("sum of the {0} / {1} = {2}", x, y, Math.Round(fraction));
            Console.ReadLine();
        }
    }
}
