using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model;

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
        private Address _address;

        /// <summary>
        /// Корзина товаров.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Коллекция заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Приоритетный покупатель.
        /// </summary>
        private bool _isPriority;

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
        /// Возвращает и задает адрес доставки для покупателя.
        /// Должен стостоять только из символов русского и английского алфавита.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор для всех объектов класса.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает и задает корзину товаров.
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
            set {_cart = value; }
        }

        /// <summary>
        /// Возвращает и задает коллекцию заказов.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Возвращает и задает булевое значение, является ли покупатель приоритетным или нет.
        /// </summary>
        public bool IsPriority
        {
            get
            {
                return _isPriority;
            }
            set
            {
                _isPriority = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное ФИО покупателя.</param>
        /// <param name="address">Полный адрес доставки для покупателя.</param>
        /// <param name="cart">Корзина товаров.</param>
        /// <param name="orders">Коллекция заказов.</param>
        public Customer(string fullName, Address address, Cart cart, List<Order> orders, bool isPriority)
        {
            FullName = fullName;
            Address = address;
            Cart = cart;
            Orders = orders;
            _allCustomerCount++;
            _id = _allCustomerCount;
            IsPriority = isPriority;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _allCustomerCount++;
            _id = _allCustomerCount;
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = false;
        }
    }
}
