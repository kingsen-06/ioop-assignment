using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class StudentClass
    {
        public string StuID { get; set; }
        public string ClassID { get; set; }

        public StudentClass(string stuID, string classID)
        {
            StuID = stuID;
            ClassID = classID;
        }
    }
}
