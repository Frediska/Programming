using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Объект, хранящий выбранный контакт.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(EditContactCommand), nameof(RemoveContactCommand))]
        private ContactVM _selectedContact;

        /// <summary>
        /// Поле, хранящее значение для свойства окна IsReadOnly.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly = true;

        /// <summary>
        /// Поле, хранящее значение для свойства окна Visibility.
        /// </summary>
        [ObservableProperty]
        private bool _isVisible = false;

        /// <summary>
        /// Поле, хранящее значение, которое говорит о том, была ли нажата кнопка Apply.
        /// </summary>
        private bool _isApply = false;

        /// <summary>
        /// Возвращает и задает индекс выбранного контакты.
        /// </summary>
        public int SelectedIndex { get; set; }

        /// <summary>
        /// Возвращает список контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; private set; } = new ObservableCollection<ContactVM>();

        /// <summary>
        /// Возвращает и задает, возможно ли редактирование контактов.
        /// </summary>
        public bool IsEdit { get; set; }

        /// <summary>
        /// Возвращает и задает, подтверждены ли изменения.
        /// </summary>
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
                else
                {
                    IsVisible = true;
                    IsReadOnly = false;
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = ContactSerializer.Deserialize();
        }

        partial void OnSelectedContactChanged(ContactVM value)
        {
            if (!IsEdit && Contacts.Contains(value))
            {
                SelectedIndex = Contacts.IndexOf(value);
            }

            if (!IsApply)
            {
                IsApply = true;
            }
        }

        /// <summary>
        /// Принятие действий над контактом.
        /// </summary>
        [RelayCommand]
        private void ApplyContact()
        {
            if (!IsEdit)
            {
                Contacts.Add(SelectedContact);
                SelectedContact = null;
                SelectedContact = Contacts[Contacts.Count - 1];
            }
            else
            {
                Contacts[SelectedIndex] = SelectedContact;
                SelectedContact = Contacts[SelectedIndex];
            }

            IsApply = true;
        }

        /// <summary>
        /// Добавляет контакт.
        /// </summary>
        [RelayCommand]
        private void AddContact()
        {
            SelectedContact = new ContactVM(new Contact());

            IsApply = false;
        }

        /// <summary>
        /// Редактирование контакта.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanExecuteEdit))]
        private void EditContact()
        {
            IsEdit = true;

            var tempContact = SelectedContact;
            SelectedContact = null;
            SelectedContact = (ContactVM)tempContact.Clone();

            IsApply = false;
        }

        /// <summary>
        /// Удаление контакта.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanExecuteRemove))]
        private void RemoveContact()
        {
            if (Contacts.Count == 1)
            {
                Contacts.Remove(SelectedContact);
            }
            else if (SelectedIndex < Contacts.Count - 1)
            {
                Contacts.Remove(SelectedContact);
                SelectedContact = Contacts[SelectedIndex];
            }
            else
            {
                Contacts.Remove(SelectedContact);
                SelectedContact = Contacts[SelectedIndex - 1];
            }
        }

        /// <summary>
        /// Определяет возможность редактирования контакта.
        /// </summary>
        /// <returns>Возвращает данные о состоянии списка.</returns>
        private bool CanExecuteEdit()
        {
            return Contacts.Count > 0 && SelectedContact != null;
        }

        /// <summary>
        /// Определяет возможность удаления контакта.
        /// </summary>
        /// <returns>Возвращает данные о состоянии списка.</returns>
        private bool CanExecuteRemove()
        {
            return Contacts.Count > 0 && SelectedContact != null;
        }

        /// <summary>
        /// Сохранение списка контактов.
        /// </summary>
        public void Save()
        {
            ContactSerializer.Serialize(Contacts);
        }
    }
}
