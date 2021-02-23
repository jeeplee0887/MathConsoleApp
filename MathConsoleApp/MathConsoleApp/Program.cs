using System;
using System.Collections.Generic;
using System.Linq;

namespace MathConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle(3);
            Square sq = new Square(4);
            Triangle tr = new Triangle(3, 3, 4, 5);
            Rectangle rt = new Rectangle(4, 5);
            Console.WriteLine("Name: {0}, Perimeter: {1}, Area: {2}", cir.Name, cir.Perimeter, cir.SurfaceArea);
            Console.WriteLine("Name: {0}, Perimeter: {1}, Area: {2}", sq.Name, sq.Perimeter, sq.SurfaceArea);
            Console.WriteLine("Name: {0}, Perimeter: {1}, Area: {2}", tr.Name, tr.Perimeter, tr.SurfaceArea);
            Console.WriteLine("Name: {0}, Perimeter: {1}, Area: {2}", rt.Name, rt.Perimeter, rt.SurfaceArea);
            //sort
            List<Shape> shapes = new List<Shape>();
            shapes.Add(cir);
            shapes.Add(sq);
            shapes.Add(tr);
            shapes.Add(rt);
            List<Shape> sortedList = shapes.OrderBy(x => x.Perimeter).ToList();
            //save to local file
            cir.StoreShape();
            //instance counts
            Console.WriteLine("Circles: {0}, Triangles: {1}, Squares: {2}, Retangles: {3}", Circle.count, Triangle.count, Square.count, Rectangle.count);
            Console.ReadLine();
        }
    }
}
