using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.RideHailingSystem
{
    public class RideHailingMain
    {
        static void Main(string[] args)
        {
            Vehical v2 = new Car(101, "Rishita", 15);
            Vehical v1 = new Bike(102, "Dev", 8);
            Vehical v3 = new Auto(103, "Rama", 10);
            double distance = 10;
            v1.GetVehicalDetails();
            Console.WriteLine("Fare " + v1.CalculateFare(distance));
            v2.GetVehicalDetails();
            Console.WriteLine("Fare: " + v2.CalculateFare(distance));
            v3.GetVehicalDetails();
            Console.WriteLine("Fare: " + v3.CalculateFare(distance));
        }
    }
}
