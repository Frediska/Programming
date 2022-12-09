using System;
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
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        private List<Order> _orders;

        private Order _currentOrder;

        public OrdersTab()
        {
            InitializeComponent();

            _orders = new List<Order>();

            var orderStatusValues = Enum.GetValues(typeof(ОrderStatus));

            foreach (var value in orderStatusValues)
            {
                SelectedOrderStatusComboBox.Items.Add(value);
            }
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
    }
}
