using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.HybridInheritence
{
    public class PetrolVehicle : Vehicle, IRefuelable
    {
        public void Refuel()
        {
            Console.WriteLine(model + " is refueling with petrol.");
        }
    }
}
