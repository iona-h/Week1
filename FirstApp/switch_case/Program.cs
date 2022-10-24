using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user input
            int x = 0;
            Console.Write("Enter a positive number: ");
            x = Convert.ToInt16(Console.ReadLine());

            //switch block
            if (x >= 0)
            {
                switch(x)
                {
                    case 0:
                        Console.WriteLine("Value of x is zero:");
                        Console.WriteLine("x={0} is zero:", x);
                        break;
                    case 1:
                        Console.WriteLine("Value of x is 1:");
                        Console.WriteLine("x={0} is 1:", x);
                        break;
                    case 2:
                        Console.WriteLine("Value of x is 2:");
                        Console.WriteLine("x={0} is 2:", x);
                        break;
                    default:
                        Console.WriteLine("Value of x > 2");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Negative numbers not allowed!");
            }

            Console.ReadLine();

        }
    }
}
