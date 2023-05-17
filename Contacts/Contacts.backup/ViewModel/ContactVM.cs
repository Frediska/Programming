using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel, агрегирующий в себе класс <see cref="Model.Contact"/>
    /// </summary>
    public class ContactVM : INotifyPropertyChanged, ICloneable
    {
        public Contact Contact { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ContactVM(Contact contact)
        {
            Contact = contact;
        }

        public string Name
        {
            get
            {
                return Contact.Name;
            }
            set
            {
                Contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Phone
        {
            get
            { 
                return Contact.Phone; 
            }
            set
            {
                Contact.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        public string Email
        {
            get
            {
                return Contact.Email;
            }
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string properyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properyName));
        }

        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }
    }
}
