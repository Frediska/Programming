using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер контакта.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Электронная почта контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="email">Электронная почта контакта.</param>
        /// <param name="phone">Номер контакта.</param>
        public Contact(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }


        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Возвращает и задаёт телефон контакта.
        /// </summary>
        public string Phone { get; set; }


        /// <summary>
        /// Возвращает и задаёт электронную почту контакта.
        /// </summary>
        public string Email { get; set; }
    }
}
