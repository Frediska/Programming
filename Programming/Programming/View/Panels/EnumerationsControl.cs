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
using Color = Programming.Model.Enums.Color;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет реализацию по представлению перечислений.
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="EnumerationControl"/>.
        /// </summary>
        public EnumerationsControl()
        {
            InitializeComponent();

            foreach (Enums enumValue in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(enumValue);
            }

            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var enumChoose = EnumsListBox.SelectedIndex;
            var itemName = (Enums)enumChoose;

            switch (itemName)
            {
                case Enums.Weekday:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Weekday)));
                    break;
                case Enums.Genre:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Genre)));
                    break;
                case Enums.Color:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Color)));
                    break;
                case Enums.Season:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Season)));
                    break;
                case Enums.EducationForm:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(EducationForm)));
                    break;
                case Enums.Manufactures:
                    ValuesListBox.Items.AddRange(Enum.GetNames(typeof(Manufactures)));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexEnum = (int)ValuesListBox.SelectedIndex;
            IntValueTextBox.Text = indexEnum.ToString();
        }
    }
}
