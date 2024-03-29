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
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private string[] _deliveryTime =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        private PriorityOrder _currentPriorityOrder;

        private Random _randomForAddItem;

        public PriorityOrdersTab()
        {
            InitializeComponent();
            _currentPriorityOrder = new PriorityOrder();
            _currentPriorityOrder.Items = new List<Item>();
            _currentPriorityOrder.Address = new Address();
            IDTextBox.Text = _currentPriorityOrder.Id.ToString();
            CreatedTextBox.Text = _currentPriorityOrder.DateOfCreateOrder;

            foreach (var time in _deliveryTime)
            {
                DeliveryTimeComboBox.Items.Add(time);
            }
            DeliveryTimeComboBox.SelectedIndex = 0;

            var orderStatusValues = Enum.GetValues(typeof(ОrderStatus));

            foreach (var status in orderStatusValues)
            {
                StatusComboBox.Items.Add(status);
            }

            StatusComboBox.SelectedIndex = 0;
            addressControl1.Address = _currentPriorityOrder.Address;

            _randomForAddItem = new Random();
        }

        public List<Item> Items { get; set; }

        private void CreateNewPriorityOrder()
        {
            _currentPriorityOrder = new PriorityOrder();
            _currentPriorityOrder.Items = new List<Item>();
            _currentPriorityOrder.Address = new Address();
            addressControl1.Address = _currentPriorityOrder.Address;
            IDTextBox.Text = _currentPriorityOrder.Id.ToString();
            CreatedTextBox.Text = _currentPriorityOrder.DateOfCreateOrder;
            DeliveryTimeComboBox.SelectedIndex = 0;
            StatusComboBox.SelectedIndex = 0;
            OrderItemsListBox.Items.Clear();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPriorityOrder.Status = (ОrderStatus)StatusComboBox.SelectedItem;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPriorityOrder.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = OrderItemsListBox.SelectedIndex;
            if (index == -1) return;

            _currentPriorityOrder.Items.RemoveAt(index);
            OrderItemsListBox.Items.RemoveAt(index);
            AllAmountLabel.Text = _currentPriorityOrder.Amount.ToString();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            CreateNewPriorityOrder();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item item = Items[_randomForAddItem.Next(Items.Count)];
            _currentPriorityOrder.Items.Add(item);
            OrderItemsListBox.Items.Add(item.Name);
            AllAmountLabel.Text = _currentPriorityOrder.Amount.ToString();
        }
    }
}
