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
        private int _yearRelease;
        private double _rating;

        public Movie(int durationMinutes, int yearRealease, int rating, string nameFilm, string genre)
        {
            DurationMinutes = durationMinutes;
            YearRelease = yearRealease;
            Rating = rating;
            NameFilm = nameFilm;
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
                if (value <= 0)
                {
                    throw new ArgumentException("duration must be positive and greater then zero");
                }
                _durationMinutes = value;
            }
        }

        public int YearRelease
        {
            get 
            { 
                return _yearRelease; 
            }
            set
            {
                if (value > 2022 || value < 1900)
                {
                    throw new ArgumentException("the film's release year must be between 1900 and 2022");
                }
                _yearRelease = value;
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

        public string NameFilm { get; set; }

        public string Genre { get; set; }
    }
}
