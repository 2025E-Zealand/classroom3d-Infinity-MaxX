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
        public string GetSeasonOfBirth()
        {
            switch (BirthMonth)
            {
                case 1: return ("Winter");
                case 2: return ("Winter");
                case 3: return ("Spring");
                case 4: return ("Spring");
                case 5: return ("Spring");
                case 6: return ("Summer");
                case 7: return ("Summer");
                case 8: return ("Summer");
                case 9: return ("Autumn");
                case 10: return ("Autumn");
                case 11: return ("Autumn");
                case 12: return ("Winter");
                default: throw new Exception("Ikke godkendt måned: " + BirthMonth);
            }
        }
        
        public override string ToString()
        {
            return $"Name: {Name}\nBirthday: {Birthday}/{BirthMonth}";
        }
        #endregion
    }
}
