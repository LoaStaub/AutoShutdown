using System;
using System.Diagnostics;

namespace AutoShutdown.Classes
{
    public class Shutdown
    {
        public void Date(DateTime endDate)
        {
            var span1 = endDate - DateTime.Now;
            var logic1 = ((span1.Days * 24 + span1.Hours) * 60 + span1.Minutes) * 60 + span1.Seconds;
            Process.Start("shutdown", $"/s /t {logic1}");
        }

        public void Time()
        {

        }

        public class Parse
        {
            public static DateTime ParseEndDate(DateTime datePicker, DateTime timePicker)
            {
                return new DateTime(datePicker.Year, datePicker.Month, datePicker.Day,
                    timePicker.Hour, timePicker.Minute, timePicker.Second);
            }
        }
    }
}
