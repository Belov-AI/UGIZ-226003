using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var braces = new Dictionary<char, char>();
            braces[')'] = '(';
            braces[']'] = '[';
            braces['}'] = '{';

            Console.WriteLine("Введите выражение со скобками");
            string expression = Console.ReadLine();

            if (expression == string.Empty)
                return;

            var stack = new Stack<char>();

            bool result = true;

            for (var i = 0; i < expression.Length; i++)
            {
                var ch = expression[i];

                if (braces.ContainsValue(ch))
                    stack.Push(ch);
                else if (braces.ContainsKey(ch))               
                    if (stack.Count == 0 || stack.Pop() != braces[ch])
                    {
                        result = false;
                        break;
                    }
            }       

                if (!result && stack.Count == 0)
                    Console.WriteLine("Скобки расставлены верно");
                else
                    Console.WriteLine("Скобки расставлены неверно");

            var queuesDict = new SortedDictionary<int, Queue<int>>();

            var rnd = new Random();

            for(var i = 0; i < 100; i++)
            {
                var number = rnd.Next(0, 1000000);
                Console.Write(number + " ");

                var key = number % 10;


                if (!queuesDict.ContainsKey(key))
                    queuesDict[key] = new Queue<int>();

                queuesDict[key].Enqueue(number);              
            }

            Console.WriteLine("\n");

            foreach(var key in queuesDict.Keys)
            {
                Console.WriteLine($"Числа, заначивающиеся на {key}:");
                PrintCollection(queuesDict[key]);
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }

        static void PrintCollection<T>(T collection)
            where T : IEnumerable
        {
            //Console.WriteLine("Коллекция элементов " + typeof(T).Name);

            foreach (var elem in collection)
                Console.Write($"{elem} ");

            Console.WriteLine("\n");
        }
    }
}
