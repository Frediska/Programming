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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();
            _customers = new List<Customer>();
        }

        private string CustomerInfo(Customer customer)
        {
            return $"{customer.Id}. {customer.FullName}";
        }

        private void UpdateCustomerInfo(int selectedIndex)
        {
            CustomersListBox.Items.Clear();

            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add($"{customer.Id}: " + $"{customer.FullName};");
            }

            if (selectedIndex == -1) return;

            CustomersListBox.SelectedIndex = selectedIndex;
        }

        public void ClearCustomerInfo()
        {
            SelectedCustomerFullNameTextBox.Clear();
            SelectedCustomerAddressTextBox.Clear();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerFactory.Randomize();
            _currentCustomer = customer;

            _customers.Add(customer);
            CustomersListBox.Items.Add(CustomerInfo(_currentCustomer));
            UpdateCustomerInfo(0);

        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _customers.RemoveAt(CustomersListBox.SelectedIndex);
                CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
                ClearCustomerInfo();
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int indexItem = CustomersListBox.SelectedIndex;
                _currentCustomer = _customers[indexItem];
                SelectedCustomerFullNameTextBox.Text = _currentCustomer.FullName;
                SelectedCustomerAddressTextBox.Text = _currentCustomer.Address;
                SelectedCustomerIDTextBox.Text = _currentCustomer.Id.ToString();
            }
        }

        private void SelectedCustomerFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    string currentCustomerFullName = SelectedCustomerFullNameTextBox.Text;
                    _currentCustomer.FullName = currentCustomerFullName;
                    int index = _customers.IndexOf(_currentCustomer);
                    UpdateCustomerInfo(index);
                }
                catch
                {
                    SelectedCustomerFullNameTextBox.BackColor = _errorColor;
                }
                SelectedCustomerFullNameTextBox.BackColor = _correctColor;
            }
        }

        private void SelectedCustomerAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    string currentCustomerAddres = SelectedCustomerAddressTextBox.Text;
                    _currentCustomer.FullName = currentCustomerAddres;
                    int index = _customers.IndexOf(_currentCustomer);
                    UpdateCustomerInfo(index);
                }
                catch
                {
                    SelectedCustomerAddressTextBox.BackColor = _errorColor;
                }
                SelectedCustomerAddressTextBox.BackColor = _correctColor;
            }
        }
    }
}
