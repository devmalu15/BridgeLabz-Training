using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.VehicleRentalSystem
{
    public class Truck:Vehicle,IInsurable
    {
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double calculateInsurance()
        {
            return 4000;
        }
        

        public string getInsuranceDetails()
        {
            return "Truck Insurance Policy";
        }
    }
}
