using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _number;

        private string _name;

        private string _surname;

        public Contact(string number, string name, string surname, string email)
        {
            Number = number;
            Email = email;
            Name = name;
            Surname = surname;
        }

        public Contact() { }

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
                        "the value of the number field must consist of 11 digits");
                }

                if (long.TryParse(value, out long num) == false)
                {
                    throw new ArgumentException(
                        "the value of the number field must consist of digits only");
                }
                _number = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = AssertStringContainsOnlyLetters(nameof(Name), value);
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = AssertStringContainsOnlyLetters(nameof(Surname), value);
            }
        }

        public string Email { get; set; }
        
        private string AssertStringContainsOnlyLetters(string nameProperty, string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException(
                        $"the {nameProperty} value must contain only English letters");
                }
            }
            return value;
        }
    }
}
