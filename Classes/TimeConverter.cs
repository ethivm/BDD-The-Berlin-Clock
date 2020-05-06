using BerlinClock.Classes;
using System;

namespace BerlinClock
{
    /// <summary>
    /// TimeConverter
    /// </summary>
    public class TimeConverter : ITimeConverter
    {
        private readonly IClockFormat clock;

        public TimeConverter(IClockFormat clock)
        {
            this.clock = clock;
        }

        public string convertTime(string aTime)
        {            
            return clock.GetTime(aTime);
        }
        
    }
}
