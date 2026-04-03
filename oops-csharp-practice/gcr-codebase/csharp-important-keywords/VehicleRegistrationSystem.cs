using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.keywords
{
    public class VehicleRegistrationSystem
    {
        static double registrationFee = 1000;
        string ownerName;
        string vehicleType;
        readonly int registrationNumber;

        public VehicleRegistrationSystem(string ownerName, string vehicleType, int registrationNumber)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
            this.registrationNumber = registrationNumber;
        }

        public static void UpdateRegistrationFee(double fee)
        {
            registrationFee = fee;
        }

        public static void Main(string[] args)
        {
            VehicleRegistrationSystem car = new VehicleRegistrationSystem("Sam", "SUV", 98765);

            if (car is VehicleRegistrationSystem)
            {
                Console.WriteLine("Valid Vehicle Object.");
                Console.WriteLine("Owner: " + car.ownerName);
                Console.WriteLine("Registration Number: " + car.registrationNumber);
                Console.WriteLine("Current Fee: " + registrationFee);
            }

            UpdateRegistrationFee(1500);
            Console.WriteLine("Updated Fee: " + registrationFee);
        }
}
