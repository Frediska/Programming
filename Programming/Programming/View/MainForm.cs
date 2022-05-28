using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color CorrectColor = System.Drawing.Color.White;
        
        private readonly System.Drawing.Color CollisionColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        private readonly System.Drawing.Color NotCollisionColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        public MainForm()
        {
            InitializeComponent();        
        }
    }
}
