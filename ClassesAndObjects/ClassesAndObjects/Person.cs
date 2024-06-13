using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person
    {
        public string Name;
        public string LastName { get; set; }

        int age;
        public int Age
        {
            get => age;

            set
            {
                if (value < 0)
                    throw new ArgumentException("Возраст не может быть < 0");

                age = value;
            }
        }

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public Person() : this("John", "Doe", 0) { }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {LastName}, возраст {Age}");
        }
    }
}
