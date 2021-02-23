using System;
using System.Collections.Generic;
using System.Text;

namespace MathConsoleApp
{
    class Circle: Shape
    {
        const double pi = 3.14;
        public static int count = 0;
        public Circle(double radius)
        {
            this.Name = "Circle";
            this.SurfaceArea = pi * radius * radius;
            this.Perimeter = 2 * pi * radius;
            count++;
        }        
    }
}
