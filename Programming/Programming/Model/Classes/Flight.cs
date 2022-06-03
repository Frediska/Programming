using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранение данных о рейсе.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полёта в минутах.
        /// </summary>
        private int _flightTimeMinutes;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Route"/>.
        /// </summary>
        /// <param name="flightTimeMinutes">Время полёта в минутах. Должно быть положительным числом.</param>
        /// <param name="departure">Место отправления.</param>
        /// <param name="destination">Место прибытия.</param>
        public Flight(int flightTimeMinutes, string departure, string destination)
        {
            FlightTimeMinutes = flightTimeMinutes;
            Departure = departure;
            Destination = destination;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Route"/>.
        /// </summary>
        public Flight() { }

        /// <summary>
        /// Возвращает и задаёт время полёта в минутах. Должно быть положительным числом.
        /// </summary>
        public int FlightTimeMinutes
        {
            get 
            { 
                return _flightTimeMinutes; 
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(FlightTimeMinutes), value);
                _flightTimeMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт место отправления.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Возвращает и задаёт место прибытия.
        /// </summary>
        public string Destination { get; set; }
    }
}
