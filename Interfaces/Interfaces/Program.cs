using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialise instance of each shape class
            Rectangle rec = new Rectangle();
            Circle circle = new Circle();
            Triangle tri = new Triangle();

            //initialise nums
            double a = 10;
            double b = 20;
            double c = 1.0;
            double area = 0.0;
            double perimeter = 0.0;

            //Rectangle
            // area
            rec.height = a;
            rec.width = b;
            area = rec.Area();
            Console.WriteLine("Area of rectangle = {0:F}", area);
            // perimeter
            perimeter = rec.perimeter();
            Console.WriteLine("Perimeter of rectangle = {0:F}", perimeter);

            Console.WriteLine("------------------------------------------");

            //Circle
            // area
            circle.radius = c;
            area = circle.Area();
            Console.WriteLine("Area of circle = {0:F}", area);
            // perimeter
            perimeter = circle.perimeter();
            Console.WriteLine("Perimeter of circle = {0:F}", perimeter);

            Console.WriteLine("------------------------------------------");

            //Triangle
            // area
            tri.side_a = 3;
            tri.side_b = 4;
            tri.side_c = 5;
            area = tri.Area();
            Console.WriteLine("Area of triangle = {0:F}", area);
            // perimeter
            perimeter = tri.perimeter();
            Console.WriteLine("Perimeter of triangle = {0:F}", perimeter);

            Console.ReadLine();
        }
    }
}
