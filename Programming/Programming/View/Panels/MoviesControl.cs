using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет реализацию по представлению фильмов.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Количество элементов.
        /// </summary>
        private const int ElementsCount = 5;

        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Массив названиий фильмов.
        /// </summary>
        private string[] _titlesMovies = { "Intouchables", "Deadly Class", "Aladdin",
            "Fight Club", "Harry Potter and the Sorcerer's Stone" };

        /// <summary>
        /// Выбранный фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MoviesControl"/>.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            _movies = CreateMovie();

            MoviesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Инициализирует массив фильмов.
        /// </summary>
        /// <returns>Возвращает массив фильмов.</returns>
        private Movie[] CreateMovie()
        {
            Movie[] movies = new Movie[ElementsCount];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = MovieFactory.Randomize();
                movies[i] = _currentMovie;
                _currentMovie.Title = _titlesMovies[i];
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
            return movies;
        }

        /// <summary>
        /// Находит фильмс наибольшим рейтингом.
        /// </summary>
        /// <param name="movies">Массив фильмов.</param>
        /// <returns>Возвращает индекс элемента коллекции, чей рейтинг больше остальных.</returns>
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int maxRatingIndex = 0;
            double maxRating = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            MovieTitleTextBox.Text = _currentMovie.Title;
            MovieGenreTextBox.Text = _currentMovie.Genre;
            MovieReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
            MovieDurationMinutesTextBox.Text = _currentMovie.DurationMinutes.ToString();
        }

        private void MovieTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            string movieTitle = MovieTitleTextBox.Text;
            _currentMovie.Title = movieTitle;
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            string genre = MovieGenreTextBox.Text;
            _currentMovie.Genre = genre;
        }

        private void MovieReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string releaseYearAsString = MovieReleaseYearTextBox.Text;
                int releaseYear = int.Parse(releaseYearAsString);
                _currentMovie.ReleaseYear = releaseYear;
            }
            catch
            {
                MovieReleaseYearTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            MovieReleaseYearTextBox.BackColor = AppColors.CorrectColor;
        }

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string ratingAsString = MovieRatingTextBox.Text;
                double rating = double.Parse(ratingAsString);
                _currentMovie.Rating = rating;
            }
            catch
            {
                MovieRatingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            MovieRatingTextBox.BackColor = AppColors.CorrectColor;
        }

        private void MovieDurationMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string durationMinutesAsString = MovieDurationMinutesTextBox.Text;
                int durationMinutes = int.Parse(durationMinutesAsString);
                _currentMovie.DurationMinutes = durationMinutes;
            }
            catch
            {
                MovieDurationMinutesTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            MovieDurationMinutesTextBox.BackColor = AppColors.CorrectColor;
        }

        private void FindMoviesButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MoviesListBox.SelectedIndex = findMaxRatingIndex;
        }
    }
}
