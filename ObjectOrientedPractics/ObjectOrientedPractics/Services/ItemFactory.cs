using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для работы с данными товара.
    /// </summary>
    public static class ItemFactory
    {
        /// <summary>
        /// Создание шаблона для заполнения информации о товаре.
        /// </summary>
        /// <returns>Шаблон для заполнения информации о товаре.</returns>
        public static Item Randomize()
        {
            Item item = new Item();
            item.Name = "Name";
            item.Cost = 1;
            item.Info = "info";

            return item;
        }
    }
}
