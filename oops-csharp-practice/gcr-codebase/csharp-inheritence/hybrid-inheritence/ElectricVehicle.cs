using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.HybridInheritence
{
    public class ElectricVehicle : Vehicle
    {
        public void Charge()
        {
            Console.WriteLine(model + " is charging battery.");
        }
    }
}
