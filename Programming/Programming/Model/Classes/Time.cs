using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int _hours;

        private int _minutes;
        
        private int _seconds;

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Time() { }

        public int Hours
        {
            get 
            { 
                return _hours; 
            }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException(
                        "the hour value must be between 0 and 23");
                }
                _hours = value;
            }
        }

        public int Minutes
        {
            get 
            { 
                return _minutes; 
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException(
                        "the minute value must be between 0 and 60");
                }
                _minutes = value;
            }
        }

        public int Seconds
        {
            get 
            { 
                return _seconds; 
            }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException(
                        "the second value must be between 0 and 60");
                }
                _seconds = value;
            }
        }
    }
}
