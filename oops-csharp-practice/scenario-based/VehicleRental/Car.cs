using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.VehicleRental
{
    public class Car : Vehicle
    {
        public String model;
        public int rentalPrice;
        public int driverRate;
        public int people;

        public Car(String model, int rentalPrice, int driverRate, String fuelType, String number, int people) : base(fuelType, number)
        {
            this.model = model;
            this.rentalPrice = rentalPrice;
            this.driverRate = driverRate;
        }
    }
}
