using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ObjectModelling
{
    public class Student
    {
        public string Name;
        public List<Course> Courses = new List<Course>();

        public Student(string name)
        {
            Name = name;
        }

        public void Enroll(Course course)
        {
            Courses.Add(course);
            course.EnrolledStudents.Add(this);
        }
    }
}
