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
        public ClassRoom() { }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"";
        }
        #endregion
    }
}
