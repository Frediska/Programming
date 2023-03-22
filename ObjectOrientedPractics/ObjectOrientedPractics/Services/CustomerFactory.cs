using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для работы с данными покупателя.
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Создание шаблона для заполнения информации о покупателе.
        /// </summary>
        /// <returns>Шаблон для заполнения информации о покупателе.</returns>
        public static Customer Randomize()
        {
            Customer customer = new Customer();
            customer.FullName = "Name";
            customer.Address = new Address();
            customer.Address.Apartment = "None";
            customer.Address.City = "None";
            customer.Address.Building = "None";
            customer.Address.Street = "None";
            customer.Address.Country = "None";
            customer.Address.Index = 111111;
            customer.Discounts.Add(new PointsDiscount());

            return customer;
        }
    }
}
