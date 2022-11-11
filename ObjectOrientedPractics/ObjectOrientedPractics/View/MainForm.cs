﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Предоставляет реализацию по представлению главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        private Store _store;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _store = ProjectSerializer.Deserialize();

            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            _store.Customers = customersTab1.Customers;
            _store.Items = itemsTab1.Items;

            ProjectSerializer.Serialize(_store);
        }
    }
}
