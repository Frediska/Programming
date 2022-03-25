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
                    throw new ArgumentException("the value of the number field must consist of 11 digits");
                }

                if (long.TryParse(value, out long num) == false)
                {
                    throw new ArgumentException("the value of the number field must consist of digits only");
                }
                _number = value;
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }
}
