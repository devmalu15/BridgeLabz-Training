using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.HeirarchicalInheritence
{
    public class Teacher : Person
    {
        public string subject;
        public void DisplayRole()
        {
            Console.WriteLine(name + " is a Teacher of " + subject);
        }
    }
}
