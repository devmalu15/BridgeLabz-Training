using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.VehicleRental
{
    public class Bike : Vehicle
    {
        public String model { get; set; }
        public int rentalPrice { get; set; }
        public int driverRate { get; set; }

        public Bike(String model, int rentalPrice, int driverRate, String fuelType, String number) : base(fuelType, number)
        {
            this.model = model;
            this.rentalPrice = rentalPrice;
            this.driverRate = driverRate;
        }

    }
}
