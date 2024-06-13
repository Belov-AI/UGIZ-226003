using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Caption : IDrawable
    {
        public double Size {  get; set; }

        public string Text { get; set; }

        public Caption(string text, double size)
        {
            Text = text;
            Size = size;
        }

        public void Draw()
        {
            Console.WriteLine($"Пишем надпись \"{Text}\"");
        }
    }
}
