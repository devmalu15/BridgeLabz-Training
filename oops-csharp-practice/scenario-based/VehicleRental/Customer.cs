using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.VehicleRental
{
    public class Customer : IPayable
    {
        public int CalculateBill(Vehicle vehicle, int distance, int hours)
        {
            int bill = 0;
            int dieselRate = 90;
            int petrolRate = 100;
            int ratePerPerson = 50;
            int mileage = 20;
            if(vehicle is Bike bike)
            {
                if(bike.fuelType == "diesel")
                {
                    bill = (dieselRate * mileage) + (bike.rentalPrice * hours) + (bike.driverRate * hours);
                }
                else
                {
                    bill = (petrolRate * mileage) + (bike.rentalPrice * hours) + (bike.driverRate * hours);
                }
            }
            else if (vehicle is Car car)
            {
                if (car.fuelType == "diesel")
                {
                    bill = (dieselRate * mileage) + (car.rentalPrice * hours) + (car.driverRate * hours) + (car.people * ratePerPerson);
                }
                else
                {
                    bill = (petrolRate * mileage) + (car.rentalPrice * hours) + (car.driverRate * hours) + (car.people * ratePerPerson);
                }
            }

            else if (vehicle is Truck truck)
            {
                if (truck.fuelType == "diesel")
                {
                    bill = (dieselRate * mileage) + (truck.rentalPrice * hours) + (truck.driverRate * hours) + (truck.loadRate * distance * truck.load);
                }
                
            }


            return bill;
        }
    }
}
