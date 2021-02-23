using System;
using System.Collections.Generic;
using System.Text;

namespace MathConsoleApp
{
    class Triangle: Shape
    {
        public static int count = 0;
        //b should be base side
        public Triangle(double h, double a, double b, double c)
        {
            if(a == b && b == c)
            {
                this.Name = "Equilateral";
            }
            else if((a != b) && (b != c) && (a != c))
            {
                this.Name = "Scalene";
            }
            else
            {
                this.Name = "Isosceles";
            }
            this.SurfaceArea = (h * b) / 2;
            this.Perimeter = a + b + c;
            count++;
        }
    }
}
