using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка по дисциплине.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="mark">Оценка по дисциплине. 
        /// Должна быть в промежутке от 0 до 5 (включительно).</param>
        /// <param name="teacherLastName">Фамилия преподавателя.</param>
        /// <param name="name">Название дисциплины.</param>
        public Subject(int mark, string teacherLastName, string name)
        {
            Mark = mark;
            Name = name;
            TeacherLastName = teacherLastName;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject() { }

        /// <summary>
        /// Возвращает и задаёт оценку по дисциплине. Должна быть в промежутке от 0 до 5 (включительно).
        /// </summary>
        public int Mark
        {
            get 
            { 
                return _mark; 
            }
            set
            {
                Validator.AssertValueInRange(nameof(Mark), value, 2, 5);
                _mark = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию преподавателя.
        /// </summary>
        public string TeacherLastName { get; set; }

        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        public string Name { get; set; }
    }
}
