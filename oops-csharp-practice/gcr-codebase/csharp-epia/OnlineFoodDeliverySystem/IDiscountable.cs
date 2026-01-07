using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.OnlineFoodDeliverySystem
{
    public interface IDiscountable
    {
        double ApplyDiscount();
        string GetDiscountDetails();
    }
}
