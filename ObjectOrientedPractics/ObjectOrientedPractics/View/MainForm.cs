using System;
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

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;

            ordersTab1.Customers = _store.Customers;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _store.Items = itemsTab1.Items;
            _store.Customers = customersTab1.Customers;

            ProjectSerializer.Serialize(_store);
        }
        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                cartsTab1.Items = itemsTab1.Items;
                cartsTab1.Customers = customersTab1.Customers;
                cartsTab1.RefreshData();
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                ordersTab1.Customers = cartsTab1.Customers;
                ordersTab1.RefreshData();
            }
        }
    }
}
