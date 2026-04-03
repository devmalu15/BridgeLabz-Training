using System;
using System.Collections.Generic;
using System.Text;

namespace ECommercePlatform.ECommercePlatform
{
    public class Groceries : Product
    {
        public override double CalculateDiscount()
        {

            return Price * 0.05;

        }

        public string GetTaxDetails()
        {
            return "Tax on Groceries: 5%";
        }

    }
}
