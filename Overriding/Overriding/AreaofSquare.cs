using System;
using System.Collections.Generic;
using System.Text;

namespace Overriding
{
    class AreaofSquare
    {
        //define square method
        public virtual double Square(double a, double b)
        {
            Console.WriteLine("Calculate area of square power a^b");
            return Math.Pow(a, 2); //replace b w 2?
        }
    }
}
