using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private int _durationSeconds;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="durationSeconds">Продолжительность песни в секундах. Должно быть положительным числом.</param>
        /// <param name="name">Название песни.</param>
        /// <param name="artist">Имя музыканта.</param>
        /// <param name="album">Альбом.</param>
        public Song(int durationSeconds, string name, string artist, string album)
        {
            DurationSeconds = durationSeconds;
            Name = name;
            Artist = artist;
            Album = album;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song() { }

        /// <summary>
        /// Возвращает и задаёт продолжительность песни в секундах. Должно быть положительным числом.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя музыканта.
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Возвращает и задаёт альбом.
        /// </summary>
        public string Album { get; set; }
    }
}
