using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.HybridInheritence
{
    public class Chef : Person, IWorker
    {
        public void PerformDuties()
        {
            Console.WriteLine("Chef " + name + " is cooking food.");
        }
    }
}
