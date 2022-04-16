using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private int _mark;

        public Subject(int mark, string teacherLastName, string name)
        {
            Mark = mark;
            Name = name;
            TeacherLastName = teacherLastName;
        }

        public Subject() { }
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

        public string TeacherLastName { get; set; }

        public string Name { get; set; }
    }
}
