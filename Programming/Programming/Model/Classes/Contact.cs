using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контактных данных человека.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _number;

        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="number">Номер телефона. Должен состоять только из цифр.
        /// Должен содержать 11 символов.</param>
        /// <param name="name">Имя. Должно состоять только из букв английского алфавита.</param>
        /// <param name="surname">Фамилия. Должно состоять только из букв английского алфавита.</param>
        /// <param name="email">Почта.</param>
        public Contact(string number, string name, string surname, string email)
        {
            Number = number;
            Email = email;
            Name = name;
            Surname = surname;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта. Должен состоять только из цифр.
        /// Должен содержать 11 символов.
        /// </summary>
        public string Number
        {
            get 
            { 
                return _number; 
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException(
                        $"the value of the {nameof(Number)} field must consist of 11 digits");
                }

                if (long.TryParse(value, out long num) == false)
                {
                    throw new ArgumentException(
                        $"the value of the {nameof(Number)} field must consist of digits only");
                }
                _number = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта. Должно состоять только из букв английского алфавита.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(Name), value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакта. Должна состоять только из букв английского алфавита.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(Surname), value);
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт почту контакта.
        /// </summary>
        public string Email { get; set; }
    }
}
