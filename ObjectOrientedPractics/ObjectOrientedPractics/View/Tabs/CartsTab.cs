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
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;

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
            CreateOrderButton.Enabled = false;
        }

        /// <summary>
        /// Возвращает и задает коллекцию товаров.
        /// </summary>
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
        /// Возвращает и задает выбранного покупателя.
        /// </summary>
        private Customer CurrentCustomer { get; set; }

        private void UpdateDiscountDigit()
        {
            double discountAmount = 0;

            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                if (DiscountsCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                }
            }

            DiscountAmmountDigitLabel.Text = discountAmount.ToString();

            if (CurrentCustomer.Cart.Amount == 0)
            {
                TOTALDigitLabel.Text = CurrentCustomer.Cart.Amount.ToString();
                return;
            }

            TOTALDigitLabel.Text = (CurrentCustomer.Cart.Amount - discountAmount).ToString();
        }

        private void UpdateDiscountsCheckedListBox()
        {
            DiscountsCheckedListBox.Items.Clear();
            foreach (var discount in CurrentCustomer.Discounts)
            {
                DiscountsCheckedListBox.Items.Add(discount.Info, true);
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
                ItemsListBox.Items.Add($"{item.Name}");
            }

            if (selectedIndex == -1) return;

            ItemsListBox.SelectedIndex = selectedIndex;
        }

        private void UpdateCartInfo(int selectedIndex)
        {
            CartListBox.Items.Clear();

            foreach (Item item in CurrentCustomer.Cart.Items)
            {
                CartListBox.Items.Add($"{item.Name}");
            }

            if (selectedIndex == -1) return;

            ItemsListBox.SelectedIndex = selectedIndex;

            CreateOrderButton.Enabled = false;
        }

        /// <summary>
        /// Обновляет данные в списках.
        /// </summary>
        public void RefreshData()
        {
            UpdateItemInfo(-1);

            CustomerComboBox.Items.Clear();

            foreach (var customer in _customers)
            {
                CustomerComboBox.Items.Add(customer.FullName);
            }

            if (CustomerComboBox.Items.Count > 0)
            {
                CustomerComboBox.SelectedIndex = 0;
            }
            else
            {
                CustomerComboBox.SelectedIndex = -1;
            }
            UpdateDiscountDigit();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomerComboBox.SelectedIndex;

            if (index == -1) return;

            CurrentCustomer = _customers[index];

            if (CurrentCustomer.Cart.Items == null) return;

            ALlAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            UpdateCartInfo(-1);
            UpdateDiscountsCheckedListBox();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 || CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Add(_items[ItemsListBox.SelectedIndex]);
                ALlAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();

                UpdateCartInfo(-1);
                CreateOrderButton.Enabled = true;
                UpdateDiscountDigit();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 || CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
                ALlAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();

                UpdateCartInfo(-1);
                UpdateDiscountDigit();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Cart = new Cart();
            UpdateCartInfo(-1);
            ALlAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            UpdateDiscountDigit();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Order order;
            if (CurrentCustomer.IsPriority)
            {
                order = new PriorityOrder();
            }
            else
            {
                order = new Order();
            }

            order.Address = CurrentCustomer.Address;
            order.Items = CurrentCustomer.Cart.Items;
            order.Status = ОrderStatus.New;

            double discountAmount = 0;
            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                if (DiscountsCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                }
            }
            order.DiscountAmount = discountAmount;
            CurrentCustomer.Orders.Add(order);

            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                if (DiscountsCheckedListBox.GetItemChecked(i))
                {
                    CurrentCustomer.Discounts[i].Apply(CurrentCustomer.Cart.Items);
                }
                CurrentCustomer.Discounts[i].Update(CurrentCustomer.Cart.Items);
            }
            UpdateDiscountsCheckedListBox();

            CurrentCustomer.Cart = new Cart();
            ALlAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            UpdateCartInfo(-1);
            CreateOrderButton.Enabled = false;
        }

        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscountDigit();
        }
    }
}
