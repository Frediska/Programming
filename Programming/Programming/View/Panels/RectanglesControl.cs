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
using Color = Programming.Model.Enums.Color;
using Rectangle = Programming.Model.Classes.Rectangle;


namespace Programming.View.Panels
{
    public partial class RectanglesControl : UserControl
    {
        private const int ElementsCount = 5;

        private readonly System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color CorrectColor = System.Drawing.Color.White;

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        public RectanglesControl()
        {
            InitializeComponent();

            _rectangles = CreateRectangles();

            RectanglesListBox.SelectedIndex = 0;
        }

        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[ElementsCount];
            var colors = Enum.GetValues(typeof(Color));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentRectangle = RectangleFactory.Randomize();
                rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            return rectangles;
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            int maxWidth = 0;
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
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
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string lengthAsString = RectangleLengthTextBox.Text;
                int rectangleLength = int.Parse(lengthAsString);
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
                int rectangleWidth = int.Parse(widthAsString);
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

        private void FindRectanglesButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }
    }
}
