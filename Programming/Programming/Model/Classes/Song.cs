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
                if (value <= 0)
                {
                    throw new ArgumentException("the duration of the song must be positive and greater than zero");
                }
                _durationSecond = value;
            }
        }

        public string Name { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }
    }
}
