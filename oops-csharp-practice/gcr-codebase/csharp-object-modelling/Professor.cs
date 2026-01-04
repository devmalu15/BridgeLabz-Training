using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ObjectModelling
{
    public class Professor
    {
        public string Name;
        public Professor(string name) { Name = name; }
        public void AssignProfessor(UniCourse c)
        {
            Console.WriteLine(Name + " is now teaching " + c.Title);
        }
    }
}
