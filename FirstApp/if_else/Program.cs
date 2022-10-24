using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialise ints
            int a = 0;
            int b = 0;

            //get user input for each number
            Console.Write("Enter 1st number (a): ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter 2nd number (b): ");
            b = Convert.ToInt32(Console.ReadLine());

            //compare numbers
            if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else if(a == b)
            {
                Console.WriteLine("a == b");
            }
            else
            {
                Console.WriteLine("a < b");
            }

            Console.ReadLine();

        }
    }
}
