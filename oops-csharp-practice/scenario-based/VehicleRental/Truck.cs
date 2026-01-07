using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.VehicleRental
{
    public class Truck : Vehicle
    {
        public String model;
        public int rentalPrice;
        public int driverRate;
        public int load;
        public int loadRate;
        public Truck(String model, int rentalPrice, int driverRate, String number, int load, int loadRate) : base("diesel", number)
        {
            this.model = model;
            this.rentalPrice = rentalPrice;
            this.driverRate = driverRate;
            this.load = load;
            this.loadRate = loadRate;
        }
    }
}
