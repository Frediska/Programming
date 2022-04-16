using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _durationSecond;

        public Song(int durationSecond, string name, string artist, string album)
        {
            DurationSecond = durationSecond;
            Name = name;
            Artist = artist;
            Album = album;
        }

        public Song() { }

        public int DurationSecond
        {
            get 
            { 
                return _durationSecond; 
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationSecond), value);
                _durationSecond = value;
            }
        }

        public string Name { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }
    }
}
