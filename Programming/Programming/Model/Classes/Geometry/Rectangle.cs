using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int MaxWidthOfRectangle = 110;

        private static int MaxLengthOfRectangle = 110;

        private static int MinWidthOfRectangle = 10;

        private static int MinLengthOfRectangle = 10;

        private static int _allRectanglesCount;

        private int _length;

        private int _width;

        private int _id;

        public Rectangle(Rectangle rectangle)
        {
            Id = rectangle.Id;
            Length = rectangle.Length;
            Width = rectangle.Width;
            Color = rectangle.Color;
            Center = new Point2D(rectangle.Center.X, rectangle.Center.Y);
        }

        public Rectangle(int length, int width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle() 
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Point2D Center { get; set; }

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Length), value);
                Validator.AssertValueInRange(nameof(Length), value, MinLengthOfRectangle, MaxLengthOfRectangle);
                _length = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                Validator.AssertValueInRange(nameof(Width), value, MinWidthOfRectangle, MaxWidthOfRectangle);
                _width = value;
            }
        }
        
        public string Color { get; set; }
    }
}
