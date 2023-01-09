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
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.View.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет реализацию по представлению покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создает экземпляр класса <see cref="CustomersTab"/>
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();

            EnabledField(false);
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
                    UpdateCustomerInfo(-1);
                }
            }
        }

        private void UpdateDiscountsListBox()
        {
            DiscountsListBox.Items.Clear();

            foreach (var discount in _currentCustomer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        void EnabledField(bool enabled)
        {
            AddressControl.Enabled = enabled;
            IsPriorityCheckBox.Enabled = enabled;
            SelectedCustomerFullNameTextBox.Enabled = enabled;
            DiscountsListBox.Enabled = enabled;
            AddDiscountButton.Enabled = enabled;
            RemoveDiscountButton.Enabled = enabled;
        }

        /// <summary>
        /// Из данных покупателя преобразует текст.
        /// </summary>
        /// <param name="customer">Покупатель.</param>
        /// <returns>Возвращает текст.</returns>
        private string CustomerInfo(Customer customer)
        {
            return $"{customer.Id}. {customer.FullName}";
        }

        /// <summary>
        /// Обновляет данные о покупателе.
        /// </summary>
        /// <param name="selectedIndex"></param>
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

        /// <summary>
        /// Очищает поля ввода информации.
        /// </summary>
        public void ClearCustomerInfo()
        {
            SelectedCustomerIDTextBox.Clear();
            SelectedCustomerFullNameTextBox.Clear();
            AddressControl.Clear();
            DiscountsListBox.Items.Clear();
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
                CustomersListBox.SelectedIndex = 0;
                EnabledField(false);
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int index = CustomersListBox.SelectedIndex;

                if (index == -1)
                {
                    EnabledField(false);
                    return;
                }
                EnabledField(true);

                int indexItem = CustomersListBox.SelectedIndex;
                _currentCustomer = _customers[indexItem];
                IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;
                SelectedCustomerFullNameTextBox.Text = _currentCustomer.FullName;
                SelectedCustomerIDTextBox.Text = _currentCustomer.Id.ToString();
                AddressControl.Address = _currentCustomer.Address;
                UpdateDiscountsListBox();
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
                    SelectedCustomerFullNameTextBox.BackColor = AppColor.ErrorColor;
                }
                SelectedCustomerFullNameTextBox.BackColor = AppColor.CorrectColor;
            }
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            AddDiscountForm addDiscountForm = new AddDiscountForm();

            if (addDiscountForm.ShowDialog() == DialogResult.OK)
            {
                foreach (var discount in _currentCustomer.Discounts)
                {
                    if (discount is PointsDiscount) continue;
                    if (((PercentDiscount)discount).Category ==
                        addDiscountForm.PercentDiscount.Category) return;
                }
                _currentCustomer.Discounts.Add(addDiscountForm.PercentDiscount);
                UpdateDiscountsListBox();
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            int index = DiscountsListBox.SelectedIndex;
            if (index == -1) return;
            if (index == 0) return;
            _currentCustomer.Discounts.RemoveAt(index);
            UpdateDiscountsListBox();
        }
    }
}
