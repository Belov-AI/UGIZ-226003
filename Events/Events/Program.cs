using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var alarmClock = new AlarmClock() { Name = "будильник" };

            var boy = new Person() { Name = "Ваня", Message = "Дай поспать!" };
            var girl = new Person() { Name = "Таня", Message = "Уже встаю..." };

            alarmClock.Ring += boy.Reply;
            alarmClock.Ring += girl.Reply;

            var dog = new Dog() { NickName = "Жучка" };
            alarmClock.Ring += dog.Bark;

            alarmClock.WakeUp("Пора вставать!");

            Console.WriteLine();

            alarmClock.Ring -= dog.Bark;

            alarmClock.WakeUp("Пора вставать!");

            Console.ReadKey();
        }
    }
}
