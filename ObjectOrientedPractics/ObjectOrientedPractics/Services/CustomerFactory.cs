using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

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
            customer.Address = "info";

            return customer;
        }
    }
}
