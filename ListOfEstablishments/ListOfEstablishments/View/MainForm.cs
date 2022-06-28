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
        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

        private List<Establishment> _establishments;

        private Establishment _currentEstablishment;

        public MainForm()
        {
            InitializeComponent();

            _establishments = ProjectSerializer.Deserialize();

            var values = Enum.GetValues(typeof(Categories));
            foreach (var value in values)
            {
                CategoryComboBox.Items.Add(value);
            }
        }

        private string EstablishmentInfo(Establishment establishment)
        {
            return $"{establishment.Id}: " +
                   $"{establishment.Category} - {establishment.Title}";
        }

        private void UpdateEstablishmentInfo()
        {
            EstablishmentsListBox.Items.Clear();

            _establishments = EstablishmentFactory.SortEstablishments(_establishments);
            foreach (var value in _establishments)
            {
                EstablishmentsListBox.Items.Add(EstablishmentInfo(value));
            }
            var index = _establishments.IndexOf(_currentEstablishment);
            EstablishmentsListBox.SelectedIndex = Convert.ToInt32(index);
        }

        public void ClearEstablishmentInfo()
        {
            TitleTextBox.Clear();
            AddressTextBox.Clear();
            RatingTextBox.Clear();
        }

        private void AddEstablishmentButton_Click(object sender, EventArgs e)
        {
            _currentEstablishment = EstablishmentFactory.DefaultInfo();

            _establishments.Add(_currentEstablishment);
            EstablishmentsListBox.Items.Add(EstablishmentInfo(_currentEstablishment));
            EstablishmentFactory.SortEstablishments(_establishments);
            UpdateEstablishmentInfo();

            EstablishmentsListBox.SelectedIndex = _establishments.Count - 1;
        }

        private void RemoveEstablishmentButton_Click(object sender, EventArgs e)
        {
            int index = EstablishmentsListBox.SelectedIndex;

            if (index != - 1)
            {
                _establishments.RemoveAt(index);
                EstablishmentsListBox.Items.RemoveAt(index);
                ClearEstablishmentInfo();

                for (int i = 0; i < _establishments.Count; i++)
                {
                    EstablishmentsListBox.Items.Add(EstablishmentInfo(_establishments[i]));
                    EstablishmentsListBox.SelectedIndex = 0;
                }
            }
            UpdateEstablishmentInfo();

            ProjectSerializer.Serialize(_establishments);
        }

        private void AddEstablishmentButton_MouseEnter(object sender, EventArgs e)
        {
            AddEstablishmentButton.Image = Properties.Resources.add_establishment_24x24;
        }

        private void AddEstablishmentButton_MouseLeave(object sender, EventArgs e)
        {
            AddEstablishmentButton.Image = Properties.Resources.add_establishment_24x24_uncolor;
        }

        private void RemoveEstablishmentButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveEstablishmentButton.Image = Properties.Resources.remove_establishment_24x24;
        }

        private void RemoveEstablishmentButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveEstablishmentButton.Image = Properties.Resources.remove_establishment_24x24_uncolor;
        }

        private void EstablishmentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EstablishmentsListBox.SelectedIndex != - 1)
            {
                int indexEstablishment = EstablishmentsListBox.SelectedIndex;
                _currentEstablishment = _establishments[indexEstablishment];
                TitleTextBox.Text = _currentEstablishment.Title;
                AddressTextBox.Text = _currentEstablishment.Address;
                RatingTextBox.Text = _currentEstablishment.Rating.ToString();
                CategoryComboBox.SelectedItem = _currentEstablishment.Category;
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EstablishmentsListBox.SelectedIndex == -1) return;

            try
            {
                string currentEstablishmentTitle = TitleTextBox.Text;
                _currentEstablishment.Title = currentEstablishmentTitle;
                UpdateEstablishmentInfo();
                ProjectSerializer.Serialize(_establishments);
            }
            catch
            {
                TitleTextBox.BackColor = _errorColor;
                return;
            }
            TitleTextBox.BackColor = _correctColor;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EstablishmentsListBox.SelectedIndex == -1) return;

            try
            {
                string currentEstablishmentAddress = AddressTextBox.Text;
                _currentEstablishment.Address = currentEstablishmentAddress;
                ProjectSerializer.Serialize(_establishments);
            }
            catch
            {
                AddressTextBox.BackColor = _errorColor;
                return;
            }
            AddressTextBox.BackColor = _correctColor;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EstablishmentsListBox.SelectedItem == null) return;

            _currentEstablishment.Category = (Categories)CategoryComboBox.SelectedItem;
            UpdateEstablishmentInfo();
            ProjectSerializer.Serialize(_establishments);
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EstablishmentsListBox.SelectedIndex == -1) return;

            try
            {
                string ratingAsString = RatingTextBox.Text;
                double currentEstablishmentRating = double.Parse(ratingAsString);
                _currentEstablishment.Rating = currentEstablishmentRating;
                ProjectSerializer.Serialize(_establishments);
            }
            catch
            {
                RatingTextBox.BackColor = _errorColor;
                return;
            }
            RatingTextBox.BackColor = _correctColor;
        }
    }
}
