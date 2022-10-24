using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int: {0}", sizeof(int)); //4
            Console.WriteLine("Size of long: {0}", sizeof(long)); //8
            Console.WriteLine("Size of float: {0}", sizeof(float)); //4
            Console.WriteLine("Size of double: {0}", sizeof(double)); //8
            Console.WriteLine("Size of decimal: {0}", sizeof(decimal)); //16
            Console.WriteLine("Size of boolean: {0}", sizeof(bool)); //1
            Console.WriteLine("Size of char: {0}", sizeof(char)); //2
            Console.WriteLine("Size of byte: {0}", sizeof(int)); //4

            Console.ReadLine();

        }
    }
}
