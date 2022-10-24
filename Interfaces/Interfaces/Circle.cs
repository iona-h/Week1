using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Circle : IShape
    {
        //data members
        public double radius { get; set; }
        //methods
        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public double perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
