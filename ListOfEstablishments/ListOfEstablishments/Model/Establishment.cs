using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEstablishments.Model
{
    public class Establishment
    {
        private static int _allEstablishmentsCount;

        private int _id;

        private string _title;

        private string _address;

        private double _rating;

        public static int AllEstablishmentsCount { get { return _allEstablishmentsCount; } }

        public Establishment(string title, string address, double rating, Categories category)
        {
            Title = title;
            Address = address;
            Rating = rating;
            Category = category;
            _allEstablishmentsCount++;
            _id = _allEstablishmentsCount;
        }

        public Establishment()
        {
            _allEstablishmentsCount++;
            _id = _allEstablishmentsCount;
        }

        public Categories Category { get; set; }

        public string Title
        {
            get { return _title; }
            set
            {
                Validator.NoMoreThan(value, 200, nameof(Title));
                Validator.AssertStringContainsOnlyLetters(nameof(Title), value);
                _title = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                Validator.NoMoreThan(value, 150, nameof(Address));
                _address = value;
            }
        }

        public double Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Rating), value);
                Validator.AssertValueInRange(nameof(Rating), value, 0.0, 10.0);
                _rating = value;
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string InstitutionDescription()
        {
            return $"{Id}: {Category} - {Title}";
        }
    }
}
