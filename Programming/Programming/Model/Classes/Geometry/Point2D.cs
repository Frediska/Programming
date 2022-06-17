using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о координатах центра геометрической фигуры.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Максимальная ширина конвы.
        /// </summary>
        private const int MaxCanvasWidth = 1285;

        /// <summary>
        /// Максимальная высота конвы.
        /// </summary>
        private const int MaxCanvasHeight = 798;

        /// <summary>
        /// Отступ внутри элемента размещения прямоугольников.
        /// </summary>
        private const int Margin = 15;

        /// <summary>
        /// Координата x.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата y.
        /// </summary>
        private int _y;

        /// <summary>
        ///Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X. Должна быть положительным числом.
        /// Должна быть в промежутке от 15 до 1270.</param>
        /// <param name="y">Координата Y. Должна быть положительным числом.
        /// Должна быть в промежутке от 15 до 783.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает и задаёт координату X. Должна быть положительным числом.
        /// Должна быть в промежутке от 15 до 1270.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(X), value);
                Validator.AssertValueInRange(nameof(X), value, Margin, MaxCanvasWidth - Margin);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт координату Y. Должна быть положительным числом.
        /// Должна быть в промежутке от 15 до 783.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Y), value);
                Validator.AssertValueInRange(nameof(Y), value, Margin, MaxCanvasHeight - Margin);
                _y = value;
            }
        }
    }
}
