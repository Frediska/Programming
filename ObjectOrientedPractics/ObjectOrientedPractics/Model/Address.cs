using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные об адресе.
    /// </summary>
    public class Address
    {
        public EventHandler<EventArgs> AddressChanged;

        /// <summary>
        /// Максимально возможное количество символов в почтовом индексе.
        /// </summary>
        private const int MaxLengthOfIndex = 6;

        /// <summary>
        /// Максимально возможное количество символов в названии страны\региона.
        /// </summary>
        private const int MaxLengthOfCountry = 50;

        /// <summary>
        /// Максимально возможное количество символов в названии города/населенного пункта.
        /// </summary>
        private const int MaxLengthOfCity = 50;

        /// <summary>
        /// Максимально возможное количество символов в названии улицы.
        /// </summary>
        private const int MaxLengthOfStreet = 100;

        /// <summary>
        /// Максимально возможное количество символов в номере дома.
        /// </summary>
        private const int MaxLengthOfBuilding = 10;

        /// <summary>
        /// Максимально возможное количество символов в номере квартиры/помещения. 
        /// </summary>
        private const int MaxLengthOfApartment = 10;

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/Регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город/Населенный пункт.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс. Должен состоять из не более, чем 6 цифр.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                ValueValidator.AssertValueLength(nameof(Index), value, MaxLengthOfIndex);
                if (_index != value)
                {
                    _index = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает страну/регион. Должен состоять из не более, чем 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertEmptyValue(value, nameof(Country));
                ValueValidator.AssertStringOnLength(value, MaxLengthOfCountry, nameof(Country));
                if (_country != value)
                {
                    _country = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает город/населенный пункт. Должен состоять из не более, чем 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertEmptyValue(value, nameof(City));
                ValueValidator.AssertStringOnLength(value, MaxLengthOfCity, nameof(City));
                if (_city != value)
                {
                    _city = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает улицу. Должен состоять из не более, чем 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertEmptyValue(value, nameof(Street));
                ValueValidator.AssertStringOnLength(value, MaxLengthOfStreet, nameof(Street));
                if (_street != value)
                {
                    _street = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома. Должен состоять из не более, чем 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertEmptyValue(value, nameof(Building)); 
                ValueValidator.AssertStringOnLength(value, MaxLengthOfBuilding, nameof(Building));
                if (_building != value)
                {
                    _building = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры/помещения. Должен состоять из не более,
        /// чем 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertEmptyValue(value, nameof(Apartment));
                ValueValidator.AssertStringOnLength(value, MaxLengthOfApartment, nameof(Apartment));
                if (_apartment != value)
                {
                    _apartment = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса<see cref="Address"/>.
        /// </summary>
        public Address()
        {
            
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Должен состоять из не более, чем 6 цифр.</param>
        /// <param name="country">Страна/регион. Должен состоять из не более, чем 50 символов.</param>
        /// <param name="city">Город/населенный пункт. Должен состоять из не более, чем 50 символов.</param>
        /// <param name="street">Улица. Должен состоять из не более, чем 100 символов.</param>
        /// <param name="building">Номер дома. Должен состоять из не более, чем 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Должен состоять из не более, 
        /// чем 10 символов.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
