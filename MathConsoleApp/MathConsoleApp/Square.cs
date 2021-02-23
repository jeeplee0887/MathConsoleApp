using System;
using System.Collections.Generic;
using System.Text;

namespace MathConsoleApp
{
    class Square: Shape
    {
        public static int count = 0;
        public Square(double l)
        {
            this.Name = "Square";
            this.SurfaceArea = l * l;
            this.Perimeter = 4 * l;
            count++;
        }
    }
}
