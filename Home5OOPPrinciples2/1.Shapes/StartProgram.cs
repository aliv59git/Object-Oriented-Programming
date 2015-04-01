using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Shapes
{
    public class StartProgram
    {
        static void Main(string[] args)
        {
            var circle = new Circle(2.234);
            Console.WriteLine(circle.CalculateSurface());

            Console.WriteLine();
            Shape[] shapes = new Shape[] {
                new Rectangle { Width = 3.5, Height = 12.234},
                new Triangle { Width = 1.1234, Height = 4.11},
                new Circle { Width = 2.345},
                new Circle { Width = 3, Height = 5}
            };
            foreach (var item in shapes)
            {
                Console.WriteLine(item.CalculateSurface());
            }



        }
    }
}
