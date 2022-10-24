using System;

namespace FunctionBlock
{
    class Program
    {
        //Main block
        static void Main(string[] args)
        {
            //initialise inputs
            int a = 5;
            int b = 5;
            int sum = 0;

            //call adding function
            sum = Add(a, b);
            //call square function
            int square = Square(a);

            //print
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("square = {0}", square);

            Console.ReadLine();

        }
        //define adding function
        public static int Add(int a, int b)
        {
            return a + b;
        }

        //define square function
        public static int Square(int a)
        {
            return a * a;
        }
    }
}
