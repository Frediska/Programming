﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Дата доставки.
        /// </summary>
        private DateTime _deliveryDate;

        /// <summary>
        /// Время доставки.
        /// </summary>
        private string _deliveryTime;

        /// <summary>
        /// Возвращает и задает дату доставки. 
        /// </summary>
        public DateTime DeliveryDate
        {
            get
            {
                return _deliveryDate;
            }
            set
            {
                _deliveryDate = value;
            }
        }

        /// <summary>
        /// Возвращает и задает время доставки.
        /// </summary>
        public string DeliveryTime
        {
            get
            {
                return _deliveryTime;
            }
            set
            {
                _deliveryTime = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="status">Статус заказа.</param>
        /// <param name="address">Адрес.</param>
        /// <param name="items">Товары заказа.</param>
        /// <param name="deliveryDate">Дата доставки.</param>
        /// <param name="deliveryTime">Время доставки.</param>
        public PriorityOrder(ОrderStatus status, Address address, List<Item> items, DateTime deliveryDate,
            string deliveryTime) : base(status, address, items)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }
}
