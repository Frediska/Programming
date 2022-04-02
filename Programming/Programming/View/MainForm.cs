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
        const int CountElements = 5;

        private readonly System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color CorrectColor = System.Drawing.Color.White;

        private Rectangle[] _rectangles;

        private Movie[] _movies;

        private string[] _titlesMovies = { "Intouchables", "Deadly Class", "Aladdin", 
            "Fight Club", "Harry Potter and the Sorcerer's Stone" };

        private Rectangle _currentRectangle;

        private Movie _currentMovie;

        private Random _randomValues;


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

            ChooseSeasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            _randomValues = new Random();

            _rectangles = CreateRectangles();
            RectanglesListBox.SelectedIndex = 0;

            _movies = CreateMovies();
            MoviesListBox.SelectedIndex = 0;
        }

        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[CountElements];
            var colors = Enum.GetValues(typeof(Color));
            for (int i = 0; i < CountElements; i++)
            {
                _currentRectangle = new Rectangle();
                _currentRectangle.Length = _randomValues.Next(1, 10001) / 10.0;
                _currentRectangle.Width = _randomValues.Next(1, 10001) / 10.0;
                _currentRectangle.Color = colors.GetValue
                    (_randomValues.Next(0, colors.Length)).ToString();
                rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            return rectangles;
        }

        private Movie[] CreateMovies()
        {
            Movie[] movies = new Movie[CountElements];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < CountElements; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _randomValues.Next(101) / 10.0;
                _currentMovie.ReleaseYear = _randomValues.Next(1900, DateTime.Now.Year + 1);
                _currentMovie.Genre = genres.GetValue
                    (_randomValues.Next(0, genres.Length)).ToString();
                _currentMovie.Title = _titlesMovies[i];
                _currentMovie.DurationMinutes = _randomValues.Next(30, 210);
                movies[i] = _currentMovie;
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
            return movies;
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            double maxWidth = 0;
            for (int i = 0; i < CountElements; i++)
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
            for (int i = 0; i < CountElements; i++)
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
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            TitleMovieTextBox.Text = _currentMovie.Title;
            GenreTextBox.Text = _currentMovie.Genre;
            ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            DurationMinutesTextBox.Text = _currentMovie.DurationMinutes.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currrentLength = LengthTextBox.Text;
                double lengthRectangleValue = double.Parse(currrentLength);
                _currentRectangle.Length = lengthRectangleValue;
            }
            catch
            {
                LengthTextBox.BackColor = ErrorColor;
                return;
            }
            LengthTextBox.BackColor = CorrectColor;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentWidth = WidthTextBox.Text;
                double widthRectangleValue = double.Parse(currentWidth);
                _currentRectangle.Width = widthRectangleValue;
            }
            catch
            {
                WidthTextBox.BackColor = ErrorColor;
                return;
            }
            WidthTextBox.BackColor = CorrectColor;
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangleValue = ColorTextBox.Text;
            _currentRectangle.Color = colorRectangleValue;
        }

        private void TitleMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string titleMovieValue = TitleMovieTextBox.Text;
            _currentMovie.Title = titleMovieValue;
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreValue = GenreTextBox.Text;
            _currentMovie.Genre = genreValue;
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentReleaseYear = ReleaseYearTextBox.Text;
                int releaseYearValue = int.Parse(currentReleaseYear);
                _currentMovie.ReleaseYear = releaseYearValue;
            }
            catch
            {
                ReleaseYearTextBox.BackColor = ErrorColor;
                return;
            }
            ReleaseYearTextBox.BackColor = CorrectColor;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = RatingTextBox.Text;
                double ratingMovieValue = double.Parse(currentRating);
                _currentMovie.Rating = ratingMovieValue;
            }
            catch
            {
                RatingTextBox.BackColor = ErrorColor;
                return;
            }
            RatingTextBox.BackColor = CorrectColor;
        }

        private void DurationMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentDurationMinutes = DurationMinutesTextBox.Text;
                int durationMinutesValue = int.Parse(currentDurationMinutes);
                _currentMovie.DurationMinutes = durationMinutesValue;
            }
            catch
            {
                DurationMinutesTextBox.BackColor = ErrorColor;
                return;
            }
            DurationMinutesTextBox.BackColor = CorrectColor;
        }

        private void ParsingButton_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            if (Enum.TryParse(WeekdayParsingTextBox.Text, out weekday))
            {
                WeekdayLabel.Text = $"Это день недели ({WeekdayParsingTextBox.Text} = {(int)weekday})";
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
    }
}
