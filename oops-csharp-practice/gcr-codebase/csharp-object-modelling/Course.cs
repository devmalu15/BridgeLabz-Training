using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ObjectModelling
{
    public class Course
    {
        public string CourseName;
        public List<Student> EnrolledStudents = new List<Student>();

        public Course(string name)
        {
            CourseName = name;
        }
    }
}
