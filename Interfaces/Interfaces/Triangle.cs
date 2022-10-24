using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Triangle : IShape
    {
        //data members
        public double side_a { get; set; }
        public double side_b { get; set; }
        public double side_c { get; set; }

        //methods
        public double Area()
        {
            //Herron's formula
            // find s
            double s = (side_a + side_b + side_c) /2;
            // test under sq expression
            double dividend = s * (s- side_a) * (s- side_b) * (s- side_c);
            if (dividend > 0)
            {
                return Math.Sqrt(dividend);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid Triangle");
            }
        }
        public double perimeter()
        {
            return side_a + side_b + side_c;
        }
    }
}
