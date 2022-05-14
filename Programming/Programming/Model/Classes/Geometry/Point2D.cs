using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Point2D
    {
        private const int MaxConvasWidth = 1220;

        private const int MaxConvasHeight = 750;

        private const int Margin = 15;

        private int _x;

        private int _y;

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(X), value);
                Validator.AssertValueInRange(nameof(X), value, Margin, MaxConvasWidth);
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Y), value);
                Validator.AssertValueInRange(nameof(Y), value, Margin, MaxConvasHeight);
                _y = value;
            }
        }
    }
}
