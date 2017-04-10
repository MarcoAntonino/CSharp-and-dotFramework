using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Classes
{
    public class Schedule
    {
        public Film Film { get; set; }
        public ScreeningRoom ScreeningRoom { get; set; }
        public DateTime ScheduleTime { get; set; }
        public int NumberOfAvailableSeats { get; set; }

        public void SetHour(int hour, int minute)
        {
            DateTime today = DateTime.Now;
            ScheduleTime = new DateTime(today.Year, today.Month, today.Day, hour,minute,0);
        }

    }
}
