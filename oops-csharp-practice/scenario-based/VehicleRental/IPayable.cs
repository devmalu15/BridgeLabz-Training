using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.VehicleRental
{
    public interface IPayable
    {
        public int CalculateBill(Vehicle vehicle, int distance, int hours);
    }
}
