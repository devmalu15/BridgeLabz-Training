using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ObjectModelling
{
    public class School
    {
        public string Name;
        public List<Student> Students = new List<Student>();

        public void AdmitStudent(Student s)
        {
            Students.Add(s);
        }
    }
}
