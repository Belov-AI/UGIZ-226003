using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public Point Center { get; set; }
        public double Radius { get; set; }

        public Circle(Point center, double radius) 
        { 
            Center = center;
            Radius = radius;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
