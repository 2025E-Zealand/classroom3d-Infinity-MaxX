using System;
using System.Collections.Generic;
using System.Linq;
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
        public override string ToString()
        {
            return $"Class Room: {ClassName}\nSemester Start: {SemesterStart}";
        }
        #endregion
    }
}
