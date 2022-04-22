using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Rectangle = Programming.Model.Classes.Rectangle;
using Color = Programming.Model.Enums.Color;
using Programming.Model.Classes;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int ElementsCount = 5;

        private readonly System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color CorrectColor = System.Drawing.Color.White;

        private List<Rectangle> _rectangles;

        private Movie[] _movies;

        private string[] _titlesMovies = { "Intouchables", "Deadly Class", "Aladdin", 
            "Fight Club", "Harry Potter and the Sorcerer's Stone" };

        private Rectangle _currentRectangle;

        private Movie _currentMovie;

        private Random _random;


        public MainForm()
        {
            InitializeComponent();

            foreach (Enums enumValue in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(enumValue);
            }

            EnumsListBox.SelectedIndex = 0;
            var values = Enum.GetValues(typeof(Season));
            foreach (var value in values)
            {
                ChooseSeasonComboBox.Items.Add(value);
            }

            ChooseSeasonComboBox.DropDownStyle = 
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            _random = new Random();

            CreateRectangles();

            CreateMovies();         
        }

        private void CreateRectangles()
        {
            _rectangles = new List<Rectangle>(ElementsCount);
            var colors = Enum.GetValues(typeof(Color));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentRectangle = new Rectangle();
                _currentRectangle.Length = _random.Next(1, 10001) / 10.0;
                _currentRectangle.Width = _random.Next(1, 10001) / 10.0;
                _currentRectangle.Color = colors.GetValue
                    (_random.Next(0, colors.Length)).ToString();
                _rectangles.Add(_currentRectangle);
                RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
                _currentRectangle.Center = new Point2D(
                    _random.Next(1, 100), _random.Next(1, 100));
            }
            RectanglesListBox.SelectedIndex = 0;
        }

        private void CreateMovies()
        {
            _movies = new Movie[ElementsCount];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _random.Next(101) / 10.0;
                _currentMovie.ReleaseYear = _random.Next(1900, DateTime.Now.Year + 1);
                _currentMovie.Genre = genres.GetValue
                    (_random.Next(0, genres.Length)).ToString();
                _currentMovie.Title = _titlesMovies[i];
                _currentMovie.DurationMinutes = _random.Next(30, 210);
                _movies[i] = _currentMovie;
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
            MoviesListBox.SelectedIndex = 0;
        }

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            int maxWidthIndex = 0;
            double maxWidth = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
        }

        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int maxRatingIndex = 0;
            double maxRating = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if(movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var enumChoose = EnumsListBox.SelectedIndex;
            var itemName = (Enums)enumChoose;

            switch (itemName)
            {
                case Enums.Weekday:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Weekday)));
                    break;
                case Enums.Genre:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Genre)));
                    break;
                case Enums.Color:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Color)));
                    break;
                case Enums.Season:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Season)));
                    break;
                case Enums.EducationForm:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(EducationForm)));
                    break;
                case Enums.Manufactures:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Manufactures)));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexEnum = (int)ValuesListBox.SelectedIndex;
            IntValueTextBox.Text = indexEnum.ToString();
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            RectangleLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color;
            RectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectangleIDTextBox.Text = _currentRectangle.Id.ToString();
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

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lengthAsString = RectangleLengthTextBox.Text;
                double rectangleLength = double.Parse(lengthAsString);
                _currentRectangle.Length = rectangleLength;
            }
            catch
            {
                RectangleLengthTextBox.BackColor = ErrorColor;
                return;
            }
            RectangleLengthTextBox.BackColor = CorrectColor;
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string widthAsString = RectangleWidthTextBox.Text;
                double rectangleWidth = double.Parse(widthAsString);
                _currentRectangle.Width = rectangleWidth;
            }
            catch
            {
                RectangleWidthTextBox.BackColor = ErrorColor;
                return;
            }
            RectangleWidthTextBox.BackColor = CorrectColor;
        }

        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string rectangleColor = RectangleColorTextBox.Text;
            _currentRectangle.Color = rectangleColor;
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
                MovieReleaseYearTextBox.BackColor = ErrorColor;
                return;
            }
            MovieReleaseYearTextBox.BackColor = CorrectColor;
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
                MovieRatingTextBox.BackColor = ErrorColor;
                return;
            }
            MovieRatingTextBox.BackColor = CorrectColor;
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
                MovieDurationMinutesTextBox.BackColor = ErrorColor;
                return;
            }
            MovieDurationMinutesTextBox.BackColor = CorrectColor;
        }

        private void ParsingButton_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            if (Enum.TryParse(WeekdayParsingTextBox.Text, out weekday))
            {
                WeekdayLabel.Text = $"Это день недели " +
                    $"({WeekdayParsingTextBox.Text} = {(int)weekday})";
            }
            else
            {
                WeekdayLabel.Text = "Нет такого дня недели";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var selectSeason = ChooseSeasonComboBox.SelectedItem;

            switch (selectSeason)
            {
                case Season.Winter:
                    BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Summer:
                    BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        private void FindRectanglesButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }

        private void FindMoviesButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MoviesListBox.SelectedIndex = findMaxRatingIndex;
        }

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Image.FromFile(
                @"C:\Users\Александр\source\repos\Programming\Programming\Programming\Resources\rectangle_add_24x24.png");
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Image.FromFile(
                @"C:\Users\Александр\source\repos\Programming\Programming\Programming\Resources\rectangle_add_24x24_uncolor.png");
        }

        private void RemoveRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Image.FromFile(
                @"C:\Users\Александр\source\repos\Programming\Programming\Programming\Resources\rectangle_remove_24x24.png");
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Image.FromFile(
                @"C:\Users\Александр\source\repos\Programming\Programming\Programming\Resources\rectangle_remove_24x24_uncolor.png");
        }
    }
}
