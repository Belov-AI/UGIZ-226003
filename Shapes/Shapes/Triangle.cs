using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape, IEnumerable
    {
        Point a {  get; set; }
        Point b { get; set; }
        Point c { get; set; }

        Point[] vertexes;

        public override double Area
        {
            get
            {
                var ab = Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
                var ac = Math.Sqrt((a.X -  c.X) * (a.X - c.X) + (a.Y - c.Y) * (a.Y - c.Y));
                var bc = Math.Sqrt((b.X - c.X) * (b.X - c.X) + (b.Y - c.Y) * (b.Y - c.Y));
                var p = (ab + ac + bc) / 2;

                return Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc));
            }
        }

        public Triangle(Point a, Point b, Point c) 
        { 
            this.a = a;
            this.b = b;
            this.c = c;
            vertexes = new Point[] { a, b, c };
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем треугольник с вершинами {a}, {b}, {c}");
        }

        public IEnumerator GetEnumerator()
        {
            return vertexes.GetEnumerator();
        }
    }
}
