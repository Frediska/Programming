using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListOfEstablishments.Model;

namespace ListOfEstablishments
{
    public partial class MainForm : Form
    {
        private List<Establishment> _establishments;

        private Establishment _currentEstablishment;




        public MainForm()
        {
            InitializeComponent();
        }
    }
}
