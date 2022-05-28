using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Enums;

namespace Programming.Model.Classes
{
    public static class MovieFactory
    {
        private static Random _random;

        static MovieFactory()
        {
            _random = new Random();
        }

        public static Movie Randomize()
        {
            var genres = Enum.GetValues(typeof(Genre));
            Movie movie = new Movie();

            movie.Rating = _random.Next(101) / 10.0;
            movie.ReleaseYear = _random.Next(1990, DateTime.Now.Year);
            movie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
            movie.DurationMinutes = _random.Next(40, 200);
            return movie;
        }
    }
}
