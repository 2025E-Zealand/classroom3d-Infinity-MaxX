using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        #region Instances

        #endregion

        #region Properties
        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int Birthday { get; private set; } 
        #endregion

        #region Constructor
        public Student(string name, int birthMonth, int birthday)
        {
            Name = name;
            BirthMonth = birthMonth;
            Birthday = birthday;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Name: {Name}\nBirthday: {Birthday}/{BirthMonth}";
        }
        #endregion
    }
}
