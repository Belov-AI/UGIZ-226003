using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sequences;

namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sequence = new Sequence();

            Console.WriteLine("Введите число членов полседовательности");
            var n = int.Parse(Console.ReadLine());

            var count = 0;

            Console.WriteLine("Числа Фибоначчи");

            foreach(var item in sequence.Fibonacci()) 
            {
                Console.Write($"{item} ");
                count++;

                if (count == n)
                    break;
            }

            Console.WriteLine("\n\nФакторалы");

            count = 0;

            foreach(var item in sequence.Factorial())
            {
                Console.Write($"{item} ");
                count++;

                if (count == n)
                    break;
            }


            Console.ReadKey();
        }
    }
}
