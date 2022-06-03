using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные об окружности.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус окружности.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренний радиус окружности.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="center">Координаты центра окружности.</param>
        /// <param name="outerRadius">Внешний радиус окружности. Должен быть положительным числом.
        /// Должен быть больше внутреннего радиуса.</param>
        /// <param name="innerRadius">Внутренний радиус окружности. Должен быть положительным числом.
        /// Должен быть меньше внешнего радиуса.</param>
        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        /// <summary>
        /// Возвращает и задаёт координаты центра окружности.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт внешний радиус. Должен быть положительным числом.
        /// Должен быть больше внутреннего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get 
            { 
                return _outerRadius; 
            }
            private set
            {
                Validator.AssertOnPositiveValue(nameof(OuterRadius), value);
                Validator.AssertValueInRange(nameof(OuterRadius), value, _innerRadius, double.MaxValue);
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт внутренний радиус. Должен быть положительным числом.
        /// Должен быть меньше внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get 
            { 
                return _innerRadius; 
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(InnerRadius), value);
                Validator.AssertValueInRange(nameof(InnerRadius), value, 0, _outerRadius);
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площадь окружности.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (_outerRadius * _outerRadius - _innerRadius * _innerRadius);
            }
        }
    }
}
