using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.InstanceVsClassVariablesAndMethods
{
    public class Vehicle
    {
        string ownerName;
        string vehicleType;
        static int registrationFee = 500;

        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Owner: " + ownerName);
            Console.WriteLine("Vehicle: " + vehicleType);
            Console.WriteLine("Fee: " + registrationFee);
        }

        public static void UpdateRegistrationFee(int newFee)
        {
            registrationFee = newFee;
        }

        public static void Main(string[] args)
        {
            Vehicle v = new Vehicle("Raj", "Bike");
            v.DisplayVehicleDetails();
            UpdateRegistrationFee(700);
            v.DisplayVehicleDetails();
        }
    }

}
