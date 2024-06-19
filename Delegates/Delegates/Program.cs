using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate int Function(int x);

    internal class Program
    {
        static void Main(string[] args)
        {
            Function f = Math.Abs;
            Console.WriteLine(f(-25));

            f = Square;
            Console.WriteLine(f(-25));

            var calc = new Calculator();
            f = calc.Cube;
            Console.WriteLine(f(-25));

            PrintFunctionTable(f, "x^3", 15);

            int k = 3, b = -2;

            PrintFunctionTable(x => x * x - 2 * x + 3, "x^2-2x+3", 10);

            PrintFunctionTable(x => k * x + b, $"{k}x + ({b})", 20);


            Console.ReadKey();
        }

        static int Square(int n)
        {
            return n * n;
        }

        static void PrintFunctionTable(Function f, string functionName, int rowNumber)
        {
            Console.WriteLine(new string('-', 16));
            Console.WriteLine($"  x | f(x) = {functionName}");
            Console.WriteLine(new string('-', 16));

            for(int i = 0; i < rowNumber; i++)
                Console.WriteLine($" {i,2} | {f(i)}");

            Console.WriteLine(new string('-', 16));
        }
    }
}
