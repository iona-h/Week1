using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Rectangle : IShape
    {
        //data members
        public double height { get; set; }
        public double width { get; set;  }

        //methods
        public double Area()
        {
            return height * width;
        }
        public double perimeter()
        {
            return 2 * height + 2 * width;
        }
    }
}
