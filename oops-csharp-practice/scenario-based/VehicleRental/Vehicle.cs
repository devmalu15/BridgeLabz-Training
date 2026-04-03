using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.VehicleRental
{
    public class Vehicle
    {
        public String fuelType { get; set; }
        public String number { get; set; }

        public Vehicle(String fuelType, String number)
        {
            this.fuelType = fuelType;
            this.number = number;
        }
    }
}
