using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.HybridInheritence
{
    public class Waiter : Person, IWorker
    {
        public void PerformDuties()
        {
            Console.WriteLine("Waiter " + name + " is serving tables.");
        }
    }
}
