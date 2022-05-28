using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Programming.Model.Enums.Color;

namespace Programming.Model.Classes
{
    public class RectangleFactory
    {
        private const int Margin = 15;

        private const int MaxWidthOfRectangle = 110;

        private const int MaxLengthOfRectangle = 110;

        private const int MinLengthOfRectangle = 10;

        private const int MinWidthOfRectangle = 10;

        private static Random _random = new Random();

        public static Rectangle Randomize(int widthCanvas, int lengthCanvas)
        {
            var colors = Enum.GetValues(typeof(Color));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(MinWidthOfRectangle, MaxWidthOfRectangle);
            rectangle.Length = _random.Next(MinLengthOfRectangle, MaxLengthOfRectangle);
            rectangle.Center = new Point2D(_random.Next(Margin, widthCanvas - rectangle.Width - Margin),
                _random.Next(Margin, lengthCanvas - rectangle.Length - Margin));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();

            return rectangle;
        }

        public static Rectangle Randomize()
        {
            var colors = Enum.GetValues(typeof(Color));
            Rectangle rectangle = new Rectangle();
            rectangle.Center = new Point2D(_random.Next(Margin, 500), _random.Next(Margin, 500));
            rectangle.Width = _random.Next(MinWidthOfRectangle, MaxWidthOfRectangle);
            rectangle.Length = _random.Next(MinLengthOfRectangle, MaxLengthOfRectangle);
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();

            return rectangle;
        }
    }
}
