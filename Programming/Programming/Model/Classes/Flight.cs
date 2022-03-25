using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTimeMinutes;

        public Flight(int flightTimeMinutes, string departure, string destination)
        {
            FlightTimeMinutes = flightTimeMinutes;
            Departure = departure;
            Destination = destination;
        }

        public Flight() { }

        public int FlightTimeMinutes
        {
            get 
            { 
                return _flightTimeMinutes; 
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("flight time must be positive and greater then zero");
                }
                _flightTimeMinutes = value;
            }
        }

        public string Departure { get; set; }
        public string Destination { get; set; }
    }
}
