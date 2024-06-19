using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Person
    {
        public string Name { get; set; }
        public string Message { get; set; }

        public void Reply(object sender, AlarmEventArgs e)
        {
            var alarmClock = sender as AlarmClock;

            if (alarmClock != null)
                Console.WriteLine($"{Name}: Эй, {alarmClock.Name}! Уже {e.Time.ToShortTimeString()}? {Message}");
        }
    }
}
