using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    public partial class SeasonsHandleControl : UserControl
    {
        public SeasonsHandleControl()
        {
            InitializeComponent();

            var values = Enum.GetValues(typeof(Season));
            foreach (var value in values)
            {
                ChooseSeasonComboBox.Items.Add(value);
            }

            ChooseSeasonComboBox.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var selectSeason = ChooseSeasonComboBox.SelectedItem;

            switch (selectSeason)
            {
                case Season.Winter:
                    BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Summer:
                    BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
