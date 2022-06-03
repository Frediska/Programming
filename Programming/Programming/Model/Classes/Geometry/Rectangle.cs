using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Максимальная ширина прямоугольника.
        /// </summary>
        private static int MaxWidthOfRectangle = 160;

        /// <summary>
        /// Максимальная длина прямоугольника.
        /// </summary>
        private static int MaxLengthOfRectangle = 160;

        /// <summary>
        /// Минимальная ширина прямоугольника.
        /// </summary>
        private static int MinWidthOfRectangle = 1;

        /// <summary>
        /// Минимальная длина прямоугольника.
        /// </summary>
        private static int MinLengthOfRectangle = 1;

        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private int _length;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        public Rectangle(Rectangle rectangle)
        {
            Id = rectangle.Id;
            Length = rectangle.Length;
            Width = rectangle.Width;
            Color = rectangle.Color;
            Center = new Point2D(rectangle.Center.X, rectangle.Center.Y);
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина прямоугольника. Должна быть положительным числом.
        /// Должна быть в промежутке от 1 до 160.</param>
        /// <param name="width">Ширина прямоугольника. Должна быть положительным числом.
        /// Должна быть в промежутке от 1 до 160.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Координаты центра прямоугольника.</param>
        public Rectangle(int length, int width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle() 
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Возвращает и задаёт уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Возвращает и задаёт координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт длину прямоугольника. Должна быть положительным числом.
        /// Должна быть в промежутке от 1 до 160.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Должна быть положительным числом.
        /// Должна быть в промежутке от 1 до 160.
        /// </summary>
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
        
        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }
    }
}
