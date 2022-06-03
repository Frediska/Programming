using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _durationMinutes;

        /// <summary>
        /// Год релиза фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="durationMinutes">Продолжительность фильма в минутах. 
        /// Должна быть положительным числом.</param>
        /// <param name="releaseYear">Год релиза фильма. 
        /// Должен быть в промежутке от 1900 до 2022.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть в промежутке от 0 до 10.</param>
        /// <param name="title">Название фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        public Movie(int durationMinutes, int releaseYear, int rating, string title, string genre)
        {
            DurationMinutes = durationMinutes;
            ReleaseYear = releaseYear;
            Rating = rating;
            Title = title;
            Genre = genre;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie() { }

        /// <summary>
        /// Возвращает и задаёт продолжительность фильма в минутах. Должна быть положительным числом.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт год релиза фильма. Должен быть в диапазоне от 1900 до 2022.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Должен быть в диапазоне от 0 до 10.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }
    }
}
