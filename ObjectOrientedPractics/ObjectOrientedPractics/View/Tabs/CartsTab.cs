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
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        public CartsTab()
        {
            InitializeComponent();
        }

        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;

                if (_items != null)
                {
                    UpdateItemInfo(-1);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает коллекцию покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;

                if (_customers != null)
                {
                    foreach (var customer in _customers)
                    {
                        CustomerComboBox.Items.Add(customer.FullName);
                    }
                }
            }
        }

        /// <summary>
        /// Обновляет данные о товаре.
        /// </summary>
        /// <param name="selectedIndex"></param>
        private void UpdateItemInfo(int selectedIndex)
        {
            ItemsListBox.Items.Clear();

            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add($"{item.Id}: " + $"{item.Name};");
            }

            if (selectedIndex == -1) return;

            ItemsListBox.SelectedIndex = selectedIndex;
        }

    }
}
