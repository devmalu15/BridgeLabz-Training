using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.HeirarchicalInheritence
{
    public class Staff : Person
    {
        public void DisplayRole()
        {
            Console.WriteLine(name + " is a Staff member");
        }
    }
}
