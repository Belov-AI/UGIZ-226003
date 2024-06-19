using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Dog
    {
        public string NickName { get; set; }

        public void Bark(object sender, AlarmEventArgs e)
        {
            Console.WriteLine($"{NickName}: Гав-гав!");
        }
    }
}
