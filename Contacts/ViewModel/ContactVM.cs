using CommunityToolkit.Mvvm.ComponentModel;
using Model;
using Model.Services;
using System.ComponentModel.DataAnnotations;

namespace ViewModel
{
    /// <summary>
    /// ViewModel, агрегирующий в себе класс <see cref="Model.Contact"/>
    /// </summary>
    public class ContactVM : ObservableValidator, ICloneable
    {
        /// <summary>
        /// Возвращает и получает объект класса <see cref="Model.Contact"/>
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact">Объект класса <see cref="Model.Contact"/>.</param>
        public ContactVM(Contact contact)
        {
            Contact = contact;
        }

        /// <summary>
        /// Возращает и получает имя объекта.
        /// </summary>
        [CustomValidation(typeof(ValueValidator), nameof(ValueValidator.ValidateName))]
        public string Name
        {
            get
            {
                return Contact.Name;
            }
            set
            {
                SetProperty(Contact.Name, value, Contact, (contact, name) => Contact.Name = name, true);
            }
        }

        /// <summary>
        /// Возращает и получает номер объекта.
        /// </summary>
        [CustomValidation(typeof(ValueValidator), nameof(ValueValidator.ValidatePhone))]
        public string Phone
        {
            get
            { 
                return Contact.Phone; 
            }
            set
            {
                SetProperty(Contact.Phone, value, Contact, (contact, phone) => Contact.Phone = phone, true);
            }
        }

        /// <summary>
        /// Возращает и получает почту объекта.
        /// </summary>
        [CustomValidation(typeof(ValueValidator), nameof(ValueValidator.ValidateEmail))]
        public string Email
        {
            get
            {
                return Contact.Email;
            }
            set
            {
                SetProperty(Contact.Email, value, Contact, (contact, email) => Contact.Email = email, true);
            }
        }

        /// <summary>
        /// Создает клон объекта.
        /// </summary>
        /// <returns>Объект класса <see cref="ContactVM"/>.</returns>
        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }
    }
}
