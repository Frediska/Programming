using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Количество всех товаров.
        /// </summary>
        private static int _allItemCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Полное описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает количество всех товаров.
        /// </summary>
        public static int AllItemCount { get { return _allItemCount;  } }

        /// <summary>
        /// Возвращает и задает полное название товара. Не более 200 символов.
        /// Должно состоять только из символов русского и английского алфавита.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                ValueValidator.AssertStringContainsOnlyLetters(nameof(Name), value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает полное описание товара. Не более 1000 символов.
        /// Должно состоять только из символов русского и английского алфавита.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                ValueValidator.AssertStringContainsOnlyLetters(nameof(Info), value);
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает стоимость товара. Должно быть положительным числом.
        /// Должно быть в промежутке от 0 до 100000.
        /// </summary>
        private double Cost
        {
            get { return _cost; }
            set
            {
                ValueValidator.AssertValueInRange(nameof(Cost), value, 0, 100000);
                ValueValidator.AssertOnPositiveValue(nameof(Cost), value);
                _cost = value;
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
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Полное название товара.</param>
        /// <param name="info">Полное описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _allItemCount++;
            _id = _allItemCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _allItemCount++;
            _id = _allItemCount;
        }
    }
}
