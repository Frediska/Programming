﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Коллекция заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order _currentOrder;

        private PriorityOrder _currentPriorityOrder;

        private string[] _deliveryTime =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        public OrdersTab()
        {
            InitializeComponent();

            _orders = new List<Order>();

            var orderStatusValues = Enum.GetValues(typeof(ОrderStatus));

            foreach (var value in orderStatusValues)
            {
                SelectedOrderStatusComboBox.Items.Add(value);
            }

            SelectedOrderStatusComboBox.Enabled = false;
        }

        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;

                if (_customers != null)
                {
                    UpdateOrders();
                }
            }
        }

        /// <summary>
        /// Обновление заказа.
        /// </summary>
        private void UpdateOrders()
        {
            foreach (var customer in _customers)
            {
                Address address = customer.Address;
                string fullAddress = $"{address.Index}, {address.Country}, {address.City}," +
                                     $" {address.Street}, {address.Building}, {address.Apartment}";

                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                    OrdersDataGridView.Rows.Add(order.Id.ToString(), order.DateOfCreateOrder,
                        order.Status, customer.FullName, fullAddress, order.Amount.ToString());
                }
            }
        }

        /// <summary>
        /// Обновление данных.
        /// </summary>
        public void RefreshData()
        {
            OrdersDataGridView.Rows.Clear();
            _orders = new List<Order>();

            UpdateOrders();
        }

        /// <summary>
        /// Установка значений в текстбоксах.
        /// </summary>
        private void SetValueInTextBoxes()
        {
            SelectedOrderStatusComboBox.Enabled = true;
            SelectedOrderIDTextBox.Text = _currentOrder.Id.ToString();
            SelectedOrderCreatedTextBox.Text = _currentOrder.DateOfCreateOrder;
            SelectedOrderStatusComboBox.SelectedIndex = (int)_currentOrder.Status;
            addressControl1.Address = _currentOrder.Address;

            OrderItemsListBox.Items.Clear();
            foreach (var item in _currentOrder.Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }

            AllAmountLabel.Text = _currentOrder.Amount.ToString();
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int index = OrdersDataGridView.CurrentCell.RowIndex;
            if (index == -1) return;

            _currentOrder = _orders[index];
            SetValueInTextBoxes();
        }

        private void SelectedOrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = OrdersDataGridView.CurrentCell.RowIndex;

            _currentOrder.Status = (ОrderStatus)SelectedOrderStatusComboBox.SelectedIndex;
            OrdersDataGridView.Rows[index].Cells[2].Value = (ОrderStatus)SelectedOrderStatusComboBox.SelectedIndex;
        }
    }
}