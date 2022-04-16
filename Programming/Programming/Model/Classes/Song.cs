﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private int _durationSeconds;

        public Song(int durationSeconds, string name, string artist, string album)
        {
            DurationSeconds = durationSeconds;
            Name = name;
            Artist = artist;
            Album = album;
        }

        public Song() { }

        public int DurationSeconds
        {
            get 
            { 
                return _durationSeconds; 
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationSeconds), value);
                _durationSeconds = value;
            }
        }

        public string Name { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }
    }
}