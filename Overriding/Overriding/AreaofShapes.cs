using System;
using System.Collections.Generic;
using System.Text;

namespace Overriding
{
    class AreaofShapes : AreaofSquare
    {
        //define method for finding area of rectangle
        public double Rectangle(double a, double b)
        {
            return a * b;
        }
        //override the square method in AreaofSquare
        public override double Square(double a, double b)
        {
            Console.WriteLine("Area of shapes called suqare a *b");
            return a * b;
        }
    }
}
