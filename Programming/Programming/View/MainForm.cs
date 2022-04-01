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

namespace Programming.View
{
    public partial class MainForm : Form
    {
        const int CountElements = 5;

        System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        System.Drawing.Color CorrectColor = System.Drawing.Color.White;

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangles;

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

            
        }

        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[CountElements];
            var colors = Enum.GetValues(typeof(Color));
            for (int i = 0; i < CountElements; i++)
            {
                _currentRectangles = new Rectangle();
                _currentRectangles.Length = _randomValues.Next(1, 10001) / 10.0;
                _currentRectangles.Width = _randomValues.Next(1, 10001) / 10.0;
                _currentRectangles.Color = colors.GetValue(_randomValues.Next(0, colors.Length)).ToString();
                rectangles[i] = _currentRectangles;
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            return rectangles;
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
            _currentRectangles = _rectangles[selectedIndexRectangle];
            LengthTextBox.Text = _currentRectangles.Length.ToString();
            WidthTextBox.Text = _currentRectangles.Width.ToString();
            ColorTextBox.Text = _currentRectangles.Color;
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


    }
}
