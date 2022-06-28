using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEstablishments.Model
{
    /// <summary>
    /// Хранит данные об заведении.
    /// </summary>
    public class Establishment
    {
        private static int MaxLengthTitleOfEstablishment = 200;

        private static int MaxLengthAddressOfEstablishment = 150;
        /// <summary>
        /// Количество всех заведений.
        /// </summary>
        private static int _allEstablishmentsCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Полное название заведения.
        /// </summary>
        private string _title;

        /// <summary>
        /// Полный адресс заведения.
        /// </summary>
        private string _address;

        /// <summary>
        /// Рейтинг заведения.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает количество всех заведений.
        /// </summary>
        public static int AllEstablishmentsCount { get { return _allEstablishmentsCount; } }

        /// <summary>
        /// Создает экземпляр класса <see cref="Establishment"/>.
        /// </summary>
        /// <param name="title">Полное название заведения.</param>
        /// <param name="address">Полный адрес заведения.</param>
        /// <param name="rating">Рейтинг заведения.</param>
        /// <param name="category">Категория заведения.</param>
        public Establishment(string title, string address, double rating, Categories category)
        {
            Title = title;
            Address = address;
            Rating = rating;
            Category = category;
            _allEstablishmentsCount++;
            _id = _allEstablishmentsCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Establishment"/>.
        /// </summary>
        public Establishment()
        {
            _allEstablishmentsCount++;
            _id = _allEstablishmentsCount;
        }

        /// <summary>
        /// Возвращает и задает категорию заведения.
        /// </summary>
        public Categories Category { get; set; }

        /// <summary>
        /// Возвращает и задает название заведения. Не более 200 символов.
        /// Должно состоять только из символов русского и английского алфавита.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                Validator.NoMoreThan(value, MaxLengthTitleOfEstablishment, nameof(Title));
                Validator.AssertStringContainsOnlyLetters(nameof(Title), value);
                _title = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адреса заведения. Не более 150 символов.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                Validator.NoMoreThan(value, MaxLengthAddressOfEstablishment, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг заведения. Значение должно быть положительным.
        /// Значение должно быть в промежутке от 0.0 до 10.0.
        /// </summary>
        public double Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Rating), value);
                Validator.AssertValueInRange(nameof(Rating), value, 0.0, 10.0);
                _rating = value;
            }
        }

        /// <summary>
        /// Возвращает и задает уникальный идентификатор для всех объектов класса.
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
