using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace GenericMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var stringArray = new[] { "aaa", "aba", "babb" };

            PrintArray(numbArray);
            PrintArray(stringArray);

            PrintCollection(numbArray);
            PrintCollection(stringArray);

            var list = new List<double>(new[] {1.5, -2.8, 0, 3.25 });
            PrintCollection(list);

            Console.ReadKey();
        }

        static void PrintArray<T>(T[] array)
        {
            Console.WriteLine("Массив элементов " + typeof(T).Name);

            foreach (var elem in array)
                Console.Write($"{elem} ");

            Console.WriteLine("\n");
        }

        static void PrintCollection<T> (T collection)
            where T : IEnumerable
        {
            Console.WriteLine("Коллекция элементов " + typeof(T).Name);

            foreach (var elem in collection)
                Console.Write($"{elem} ");

            Console.WriteLine("\n");
        }
    }
}
