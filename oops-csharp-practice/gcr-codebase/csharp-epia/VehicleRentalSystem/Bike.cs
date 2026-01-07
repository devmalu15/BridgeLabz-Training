using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.VehicleRentalSystem
{
    public class Bike:Vehicle,IInsurable
    {
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double calculateInsurance()
        {
            return 200; 
        }

        public string getInsuranceDetails()
        {
            return "Bike Insurance Policy";
        }
    }
}
