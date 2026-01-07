using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.OnlineFoodDeliverySystem
{
    class NonVegItem : FoodItem, IDiscountable
    {
        private const double ExtraCharge = 50;

        public NonVegItem(string name, double price, int quantity)
            : base(name, price, quantity) { }

        public override double CalculatingTotalPrice()
        {
            return (Price * Quantity) + ExtraCharge;
        }

        public double ApplyDiscount()
        {
            return CalculatingTotalPrice() * 0.05;
        }

        public string GetDiscountDetails()
        {
            return "5% discount on Non-Veg items";
        }
    }

}
