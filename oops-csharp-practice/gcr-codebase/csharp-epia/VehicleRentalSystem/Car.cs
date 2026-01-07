using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo.oops.VehicleRentalSystem
{
    public class Car : Vehicle,IInsurable
    {
        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double calculateInsurance()
        {
            return 1000;
        }

        public string getInsuranceDetails()
        {
            return "Car Insurance Policy";
        }
    }
}
