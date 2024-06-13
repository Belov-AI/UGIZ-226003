using System;
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
            List<Shape> shapes = new List<Shape>();

            var rectangle = new Rectangle(new Point(1, 1), 5, 3);
            shapes.Add(rectangle);

            var circle = new Circle(new Point(-2, 3), 2);
            shapes.Add(circle);

            foreach (var shape in shapes)
                shape.Draw();



        }
    }
}
