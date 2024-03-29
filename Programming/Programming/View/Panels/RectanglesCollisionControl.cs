﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Programming.Model.Classes.Rectangle;
using Programming.Model.Classes;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет реализацию по представлению прямоугольников.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles;

        /// <summary>
        /// Коллекция отображаемых прямоугольников.
        /// </summary>
        private List<Panel> _rectanglePanels;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectangleCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();

            _rectanglePanels = new List<Panel>();

        }

        /// <summary>
        /// Находит пересекающиеся прямоугольники и перекрашивает их.
        /// </summary>
        private void FindCollisions()
        {
            for (int k = 0; k < _rectangles.Count; k++)
            {
                CanvasPanel.Controls[k].BackColor = AppColors.NotCollisionColor;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = AppColors.CollisionColor;
                        CanvasPanel.Controls[j].BackColor = AppColors.CollisionColor;
                    }
                }
            }
        }

        /// <summary>
        /// Обновляет информацию в списке при изменении значений.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            if (rectangle != null)
            {
                var newRectangle = new Rectangle(rectangle);
                var oldRectangle = _rectangles[RectanglesListBox.SelectedIndex];

                var halfDifferenceWidth = Math.Abs(oldRectangle.Width - newRectangle.Width) / 2;
                var halfDifferenceLength = Math.Abs(oldRectangle.Length - newRectangle.Length) / 2;

                if (newRectangle.Center.X == oldRectangle.Center.X && newRectangle.Center.Y == oldRectangle.Center.Y)
                {
                    newRectangle.Center.X = oldRectangle.Width >= newRectangle.Width
                        ? oldRectangle.Center.X + halfDifferenceWidth
                        : oldRectangle.Center.X - halfDifferenceWidth;

                    newRectangle.Center.Y = oldRectangle.Length >= newRectangle.Length
                        ? oldRectangle.Center.Y + halfDifferenceLength
                        : oldRectangle.Center.Y - halfDifferenceLength;
                }

                var index = _rectangles.FindIndex(r => r.Id == newRectangle.Id);
                _rectangles[index] = newRectangle;

                var control = CanvasPanel.Controls[index];
                control.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
                control.Width = rectangle.Width;
                control.Height = rectangle.Length;

                SelectedRectangleLengthTextBox.BackColor = AppColors.CorrectColor;
                SelectedRectangleWidthTextBox.BackColor = AppColors.CorrectColor;

                FindCollisions();
            }
        }

        /// <summary>
        /// Очищает информацию о прямоугольнике с текстовых полей и со списка.
        /// </summary>
        private void ClearRectangleInfo()
        {
            RectanglesListBox.Items.Clear();
            SelectedRectangleIDTextBox.Clear();
            SelectedRectangleXTextBox.Clear();
            SelectedRectangleYTextBox.Clear();
            SelectedRectangleWidthTextBox.Clear();
            SelectedRectangleLengthTextBox.Clear();
            SelectedRectangleXTextBox.BackColor = AppColors.CorrectColor;
            SelectedRectangleYTextBox.BackColor = AppColors.CorrectColor;
            SelectedRectangleWidthTextBox.BackColor = AppColors.CorrectColor;
            SelectedRectangleLengthTextBox.BackColor = AppColors.CorrectColor;
        }

        /// <summary>
        /// Из данных прямоугольника преобразует текст.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>Возвращает текст.</returns>
        private string RectangleInfo(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" L: {rectangle.Length})";
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                int indexSelectedRectangle = RectanglesListBox.SelectedIndex;
                _currentRectangle = new Rectangle(_rectangles[indexSelectedRectangle]);
                SelectedRectangleLengthTextBox.Text = _currentRectangle.Length.ToString();
                SelectedRectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
                SelectedRectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
                SelectedRectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
                SelectedRectangleIDTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            _rectangles.Add(rectangle);
            RectanglesListBox.Items.Add(RectangleInfo(rectangle));

            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = rectangle.Width;
            rectanglePanel.Height = rectangle.Length;
            rectanglePanel.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            rectanglePanel.BackColor = AppColors.NotCollisionColor;
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
            FindCollisions();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            if (_rectangles.Count > 0)
            {
                int selectedIndexRectangle = RectanglesListBox.SelectedIndex;
                if (selectedIndexRectangle == -1) return;
                _rectangles.RemoveAt(selectedIndexRectangle);
                CanvasPanel.Controls.RemoveAt(selectedIndexRectangle);
                _rectanglePanels.RemoveAt(selectedIndexRectangle);
                ClearRectangleInfo();

                for (int i = 0; i < _rectangles.Count; i++)
                {
                    RectanglesListBox.Items.Add(RectangleInfo(_rectangles[i]));
                    RectanglesListBox.SelectedIndex = 0;
                }
                FindCollisions();
            }
        }

        private void SelectedRectangleXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string xRectangleAsString = SelectedRectangleXTextBox.Text;
                int rectangleX = int.Parse(xRectangleAsString);
                _currentRectangle.Center.X = rectangleX;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox.Items[index] = RectangleInfo(_currentRectangle);
            }

            catch
            {
                SelectedRectangleXTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            SelectedRectangleXTextBox.BackColor = AppColors.CorrectColor;
        }

        private void SelectedRectangleYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string yRectangleAsString = SelectedRectangleYTextBox.Text;
                int rectangleY = int.Parse(yRectangleAsString);
                _currentRectangle.Center.Y = rectangleY;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox.Items[index] = RectangleInfo(_currentRectangle);
            }

            catch
            {
                SelectedRectangleYTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            SelectedRectangleYTextBox.BackColor = AppColors.CorrectColor;
        }

        private void SelectedRectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string widthRectangleAsString = SelectedRectangleWidthTextBox.Text;
                int rectangleWidth = int.Parse(widthRectangleAsString);
                _currentRectangle.Width = rectangleWidth;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox.Items[index] = RectangleInfo(_currentRectangle);
            }

            catch
            {
                SelectedRectangleWidthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            SelectedRectangleWidthTextBox.BackColor = AppColors.CorrectColor;
        }

        private void SelectedRectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string lengthRectangleAsString = SelectedRectangleLengthTextBox.Text;
                int rectangleLength = int.Parse(lengthRectangleAsString);
                _currentRectangle.Length = rectangleLength;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox.Items[index] = RectangleInfo(_currentRectangle);
            }

            catch
            {
                SelectedRectangleLengthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            SelectedRectangleLengthTextBox.BackColor = AppColors.CorrectColor;
        }
    }
}
