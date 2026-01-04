using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ObjectModelling
{
    public class UniStudent
    {
        public string Name;
        public UniStudent(string name) { Name = name; }
        public void EnrollCourse(UniCourse c)
        {
            Console.WriteLine(Name + " enrolled in " + c.Title);
        }
    }
}
