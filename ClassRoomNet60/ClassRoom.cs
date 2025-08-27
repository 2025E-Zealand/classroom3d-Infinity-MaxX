using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        #region Instances
        #endregion

        #region Properties
        string ClassName { get; set; }
        List<Student> StudentList { get; set; }
        DateTime SemesterStart { get; set; }
        #endregion

        #region Constructor
        public ClassRoom()
        {
            ClassName = "A";
            StudentList = new List<Student>();
            SemesterStart = new DateTime(01/01/2000);
        }
        public ClassRoom(string className, List<Student> studentList, DateTime semesterStart)
        {
            ClassName = className;
            StudentList = studentList;
            SemesterStart = semesterStart;
        }

        #endregion

        #region Methods
        public void Count()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Winter", 0);
            dict.Add("Spring", 0);
            dict.Add("Summer", 0);
            dict.Add("Autumn", 0);

            foreach (Student student in StudentList)
            {
                dict[student.GetSeasonOfBirth()]++;
            }

            foreach(var kvp in dict)
            {
                Console.WriteLine(kvp);
            }
        }
        public override string ToString()
        {
            return $"Class Room: {ClassName}\nSemester Start: {SemesterStart}";
        }
        #endregion
    }
}
