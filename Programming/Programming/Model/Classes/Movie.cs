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
                if (value < 40)
                {
                    throw new ArgumentException("duration must be positive and greater then 60");
                }
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
                if (value > DateTime.Now.Year || value < 1900)
                {
                    throw new ArgumentException($"the film's release year must be between 1900 and {DateTime.Now.Year}");
                }
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
                if (value > 10.0 || value < 0.0)
                {
                    throw new ArgumentException("the rating of the film must be between 0 and 10");
                }
                _rating = value;
            }
        }

        public string Title { get; set; }

        public string Genre { get; set; }
    }
}
