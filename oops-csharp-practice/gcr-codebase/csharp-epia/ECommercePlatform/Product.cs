using System;
using System.Collections.Generic;
using System.Text;

namespace ECommercePlatform.ECommercePlatform
{
    // Create an abstract class Product with fields like productId, name, and price,
    // and an abstract method CalculateDiscount()
    public abstract class Product
    {

        private int productId;
        private string name;
        private double price;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public abstract double CalculateDiscount();





    }
}

