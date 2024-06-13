using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person peter = new Person();
            peter.Name = "Пётр";
            peter.LastName = "Иванов";
            peter.Age = 20;

            //peter.Age = -5;

            //PrintPerson(peter);

            peter.PrintInfo();

            var kate = new Person {Name = "Катя", LastName = "Петрова", Age = 18};
            kate.PrintInfo();

            var john = new Person();
            john.PrintInfo();

            var michael = new Person("Михаил", "Сидоров", 24);
            michael.PrintInfo();


            Console.ReadKey();
        }

        static void PrintPerson(Person person)
        {
            Console.WriteLine($"{person.Name} {person.LastName}, возраст {person.Age}");
        }
    }
}
