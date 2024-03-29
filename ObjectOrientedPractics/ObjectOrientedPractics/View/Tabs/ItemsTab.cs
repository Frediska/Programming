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
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет реализацию по представлению товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            _items = new List<Item>();

            var category = Enum.GetValues(typeof(Category));

            foreach (var value in category)
                SelectedItemCategoryComboBox.Items.Add(value);
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
        /// Из данных товара преобразует текст.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <returns>Возвращает текст.</returns>
        private string ItemInfo(Item item)
        {
            return $"{item.Id}. {item.Name}";
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

        /// <summary>
        /// Очищает поля ввода информации.
        /// </summary>
        public void ClearItemInfo()
        {
            SelectedItemIDTextBox.Clear();
            SelectedItemNameTextBox.Clear();
            SelectedItemCostTextBox.Clear();
            SelectedItemDescriptionTextBox.Clear();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item item = ItemFactory.Randomize();
            _currentItem = item;

            _items.Add(item);
            ItemsListBox.Items.Add(ItemInfo(_currentItem));
            ItemsChanged?.Invoke(this, EventArgs.Empty);
            UpdateItemInfo(0);
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
                ItemsChanged?.Invoke(this, EventArgs.Empty);
                ClearItemInfo();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int indexItem = ItemsListBox.SelectedIndex;
                _currentItem = _items[indexItem];
                SelectedItemNameTextBox.Text = _currentItem.Name;
                SelectedItemCostTextBox.Text = _currentItem.Cost.ToString();
                SelectedItemDescriptionTextBox.Text = _currentItem.Info;
                SelectedItemIDTextBox.Text = _currentItem.Id.ToString();
                SelectedItemCategoryComboBox.SelectedItem = _currentItem.Category;
            }
        }

        private void SelectedItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    string currentItemCost = SelectedItemCostTextBox.Text;
                    int itemCost = int.Parse(currentItemCost);
                    _currentItem.Cost = itemCost;
                    int index = _items.IndexOf(_currentItem);
                    ItemsChanged?.Invoke(this, EventArgs.Empty);
                    UpdateItemInfo(index);
                }
                catch
                {
                    SelectedItemCostTextBox.BackColor = AppColor.ErrorColor;
                    return;
                }
                SelectedItemCostTextBox.BackColor = AppColor.CorrectColor;
            }
        }

        private void SelectedItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    string currentItemName = SelectedItemNameTextBox.Text;
                    _currentItem.Name = currentItemName;
                    int index = _items.IndexOf(_currentItem);
                    ItemsChanged?.Invoke(this, EventArgs.Empty);
                    UpdateItemInfo(index);
                }
                catch
                {
                    SelectedItemNameTextBox.BackColor = AppColor.ErrorColor;
                }
                SelectedItemNameTextBox.BackColor = AppColor.CorrectColor;
            }
        }

        private void SelectedItemDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    string currentItemInfo = SelectedItemDescriptionTextBox.Text;
                    _currentItem.Info = currentItemInfo;
                    int index = _items.IndexOf(_currentItem);
                    ItemsChanged?.Invoke(this, EventArgs.Empty);
                    UpdateItemInfo(index);
                }
                catch
                {
                    SelectedItemDescriptionTextBox.BackColor = AppColor.ErrorColor;
                }
                SelectedItemDescriptionTextBox.BackColor = AppColor.CorrectColor;
            }
        }

        private void SelectedItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null) return;
            
            _currentItem.Category = (Category)SelectedItemCategoryComboBox.SelectedItem;
            int index = _items.IndexOf(_currentItem);
            ItemsChanged?.Invoke(this, EventArgs.Empty);
            UpdateItemInfo(index);
        }
    }
}
