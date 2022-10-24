using System;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialise instance of AreaofShapes
            AreaofShapes areaShapes = new AreaofShapes();
            AreaofSquare areaSquare = new AreaofSquare();

            //initialise parameters
            double a = 5.00;
            double b = 10.00;
            double area = 0.0;

            //calc area
            area = areaShapes.Square(a, b);
            Console.WriteLine("area of square : {0}", area);

            area = areaSquare.Square(a, b);
            Console.WriteLine("area of square : {0}", area);

            Console.ReadLine();
        }
    }
}
