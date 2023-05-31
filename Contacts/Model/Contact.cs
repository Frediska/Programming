using System;

namespace Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact : ICloneable
    {
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

        /// <summary>
        /// Возвращает копию экземпляра класса <see cref="Contact"/>
        /// </summary>
        /// <returns>Объект класса <see cref="Contact"/>.</returns>
        public object Clone()
        {
            return new Contact(Name, Email, Phone);
        }
    }
}
