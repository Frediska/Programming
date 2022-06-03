using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _durationMinutes;
        private int _releaseYear;
        private double _rating;

        public Movie(int durationMinutes, int releaseYear, int rating, string title, string genre)
        {
            DurationMinutes = durationMinutes;
            ReleaseYear = releaseYear;
            Rating = rating;
            Title = title;
            Genre = genre;
        }

        public Movie() { }

        public int DurationMinutes
        {
            get 
            { 
                return _durationMinutes; 
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationMinutes), value);
                _durationMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get 
            { 
                return _releaseYear; 
            }
            set
            {
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 1900, DateTime.Now.Year);
                _releaseYear = value;
            }
        }

        public double Rating
        {
            get 
            { 
                return _rating; 
            }
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0.0, 10.0);
                _rating = value;
            }
        }

        public string Title { get; set; }

        public string Genre { get; set; }
    }
}
