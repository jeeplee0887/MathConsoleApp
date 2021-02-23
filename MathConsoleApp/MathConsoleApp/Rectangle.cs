using System;
using System.Collections.Generic;
using System.Text;

namespace MathConsoleApp
{
    class Rectangle: Shape
    {
        public static int count = 0;
        public Rectangle(double w, double l)
        {
            if (w == l)
            {
                this.Name = "Square";
            }
            else
            {
                this.Name = "Rectangle";
            }
            this.Perimeter = 2 * (w + l);
            this.SurfaceArea = w * l;
            count++;
        }
    }
}
