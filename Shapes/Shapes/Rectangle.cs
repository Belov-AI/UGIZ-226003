using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Point LetTop { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area => Width * Height;

        public Rectangle(Point leftTop, double width, double height) 
        { 
            LetTop = leftTop;
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine("Рисуем прямоугольник");
        }
    }
}
