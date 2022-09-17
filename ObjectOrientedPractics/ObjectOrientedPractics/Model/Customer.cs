using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        ///  Количество всех покупателей.
        /// </summary>
        private static int _allCustomerCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное ФИО покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Полный адрес доставки для покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает количество всех покупателей. 
        /// </summary>
        public static int AllCustomerCount { get { return _allCustomerCount; } }

        /// <summary>
        /// Возвращает и задает ФИО покупателя. Не более 200 символов.
        /// Должно стостоять только из символов русского и английского алфавита.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                ValueValidator.AssertStringContainsOnlyLetters(nameof(FullName), value);
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки для покупателя. Не более 500 символов.
        /// Должен стостоять только из символов русского и английского алфавита.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                ValueValidator.AssertStringContainsOnlyLetters(nameof(Address), value);
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор для всех объектов класса.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное ФИО покупателя.</param>
        /// <param name="address">Полный адрес доставки для покупателя.</param>
        public Customer(string fullName, string address)
        {
            FullName = fullName;
            Address = address;
            _allCustomerCount++;
            _id = _allCustomerCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _allCustomerCount++;
            _id = _allCustomerCount;
        }
    }
}
