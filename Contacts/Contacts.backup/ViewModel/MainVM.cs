using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using View.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Interop;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(EditContactCommand), nameof(RemoveContactCommand))]
        private ContactVM _selectedContact;

        [ObservableProperty]
        private bool _isReadOnly = true;

        [ObservableProperty]
        private bool _isVisible = false;

        private bool _isApply = false;

        public MainVM()
        {
            Contacts = ContactSerializer.Load();
        }

        public int SelectedIndex { get; set; }

        public Contact Contact { get; private set; } = new Contact();

        public ObservableCollection<ContactVM> Contacts { get; private set; } =
            new ObservableCollection<ContactVM>();

        public bool IsEdit { get; set; }

        public bool IsApply
        {
            get
            {
                return _isApply;
            }
            set
            {
                _isApply = value;

                if (value)
                {
                    IsEdit = false;
                    IsVisible = false;
                    IsReadOnly = true;
                }
            }
        }
    }
}
