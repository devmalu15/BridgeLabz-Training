using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Constructors
{
    public class CarRental
    {
        string customerName;
        string carModel;
        int rentalDays;

        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
        }

        public void CalculateCost()
        {
            double dailyRate = 1000;
            double total = rentalDays * dailyRate;
            Console.WriteLine("Total Cost for " + customerName + ": " + total);
        }

        public static void Main(string[] args)
        {
            CarRental rent = new CarRental("Tom", "Sedan", 5);
            rent.CalculateCost();
        }
    }
}
