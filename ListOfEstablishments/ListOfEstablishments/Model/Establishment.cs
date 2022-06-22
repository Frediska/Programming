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

        private string _title;

        private string _address;

        private double _rating;

        private int _id;

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
                Validator.AssertStringContainsOnlyLetters(nameof(Title), value);
                _title = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(Address), value);
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
    }
}
