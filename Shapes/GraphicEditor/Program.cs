﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace GraphicEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDrawable> shapes = new List<IDrawable>();

            var rectangle = new Rectangle(new Point(1, 1), 5, 3);
            shapes.Add(rectangle);

            var circle = new Circle(new Point(-2, 3), 2);
            shapes.Add(circle);

            var txt = new Caption("Hello,World", 10);
            shapes.Add(txt);

            var triangle = new Triangle(new Point(0,1), new Point(3, 2), new Point(4, 3));
            shapes.Add(triangle);

            foreach (var shape in shapes)
                shape.Draw();

            Console.WriteLine("\nВершины треугольника");

            foreach (var vertex in triangle)
                Console.WriteLine(vertex);

            


            Console.ReadKey();
        }
    }
}
