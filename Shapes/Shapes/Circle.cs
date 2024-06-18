﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public Point Center { get; set; }

        double radius;
        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value > 0)
                    radius = value;
                else
                    throw new ArgumentException("Радиус должен быть положительным");
            }
        }

        public override double Area => Math.PI * Radius * Radius;

        public Circle(Point center, double radius) 
        { 
            Center = center;
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Рисуем круг");
        }
    }
}
