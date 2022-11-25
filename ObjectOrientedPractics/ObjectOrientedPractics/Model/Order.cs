using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет реализацию по оформлению заказов.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Количество всех заказов.
        /// </summary>
        private static int _allOrdersCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly string _dateOfCreateOrder;

        /// <summary>
        /// Адрес доставки заказа.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Коллекция товаров заказа.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Общая стоимость всего заказа.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public string DateOfCreateOrder
        {
            get { return _dateOfCreateOrder; }
        }

        /// <summary>
        /// Возвращает и задает адресс доставки заказа.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает и задает коллекцию товаров заказа.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает общую стоимость заказа.
        /// </summary>
        public double Amount
        {
            get
            {
                _amount = 0;

                if (_items == null) return _amount;

                foreach (var item in _items)
                {
                    _amount += item.Cost;
                }

                return _amount;
            }
        }

        /// <summary>
        /// Возвращает и задает свойство заказа.
        /// </summary>
        public ОrderStatus Status { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адресс доставки заказа.</param>
        public Order(Address address)
        {
            _dateOfCreateOrder = DateTime.Today.ToString();
            Address = address;
            _allOrdersCount++;
            _id = _allOrdersCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _allOrdersCount++;
            _id = _allOrdersCount;
        }
    }
}
