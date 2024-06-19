using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class AlarmEventArgs : EventArgs
    {
        public DateTime Time { get; set; }
        public string EventDescription { get; set; }
    }

    public delegate void AlarmEventHandler(object sender, AlarmEventArgs e);

    public class AlarmClock
    {
        public string Name { get; set; }

        public event AlarmEventHandler Ring;

        protected virtual void OnRing(AlarmEventArgs e)
        {
            if(Ring != null)
            {
                Console.WriteLine($"{e.EventDescription}!!! Уже {e.Time.ToShortTimeString()}");
                Ring(this, e);
            }
        }

        public void WakeUp(string description)
        {
            var args = new AlarmEventArgs() { Time = DateTime.Now, EventDescription = description };    
            OnRing(args);
        }
    }
}
