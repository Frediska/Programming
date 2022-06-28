using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEstablishments.Model
{
    /// <summary>
    /// Предоставляет методы для работы с данными заведений.
    /// </summary>
    public static class EstablishmentFactory
    {
        /// <summary>
        /// Создание шаблона для заполнения информации о заведении.
        /// </summary>
        /// <returns>Шаблон для заполнения информации о заведении.</returns>
        public static Establishment DefaultInfo()
        {
            Establishment establishment = new Establishment();
            establishment.Title = "Название";
            establishment.Address = "Адрес";
            establishment.Rating = 0;
            return establishment;
        }

        /// <summary>
        /// Проводит сортировку коллекции заведений по категории и имени.
        /// </summary>
        /// <param name="establishments">Коллекция класса <see cref="Establishment"/>.</param>
        /// <returns>Возвращает отсортированную коллекцию заведений.</returns>
        public static List<Establishment> SortEstablishments(List<Establishment> establishments)
        {
            var sortedEstablishmentList = from value in establishments
                                          orderby value.Category, value.Title
                                          select value;

            return sortedEstablishmentList.ToList();
        }
    }
}
