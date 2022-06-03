using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = Programming.Model.Enums.Color;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для создания прямоугольников.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Отступ внутри элемента размещения прямоугольников.
        /// </summary>
        private const int Margin = 15;

        /// <summary>
        /// Максимальная ширина прямоугольника.
        /// </summary>
        private const int MaxWidthOfRectangle = 160;

        /// <summary>
        /// Максимальная длина прямоугольника.
        /// </summary>
        private const int MaxLengthOfRectangle = 160;

        /// <summary>
        /// Минимальная длина прямоугольника.
        /// </summary>
        private const int MinLengthOfRectangle = 1;

        /// <summary>
        /// Минимальная ширина прямоугольника.
        /// </summary>
        private const int MinWidthOfRectangle = 1;

        /// <summary>
        /// Случайные значения.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями длины, ширины и координат.
        /// </summary>
        /// <param name="widthCanvas">Ширина элемента размещения.</param>
        /// <param name="lengthCanvas">Длина элемента размещения.</param>
        /// <returns>Возвращает объект <see cref="Rectangle"/>.</returns>
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

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями длины, ширины и координат.
        /// </summary>
        /// <returns>Возвращает объект <see cref="Rectangle"/>.</returns>
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
