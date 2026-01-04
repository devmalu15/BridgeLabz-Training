using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.keywords
{
    public class ShoppingCartSystem
    {
        static double discount = 5.0;
        string productName;
        double price;
        int quantity;
        readonly int productID;

        public ShoppingCartSystem(string productName, double price, int quantity, int productID)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
            this.productID = productID;
        }

        public static void UpdateDiscount(double newDiscount)
        {
            discount = newDiscount;
        }

        public static void Main(string[] args)
        {
            ShoppingCartSystem item = new ShoppingCartSystem("Laptop", 50000, 1, 101);

            if (item is ShoppingCartSystem)
            {
                Console.WriteLine("Item is a valid Product.");
                Console.WriteLine("Product: " + item.productName);
                Console.WriteLine("Discount: " + discount + "%");
            }

            UpdateDiscount(10.0);
            Console.WriteLine("New Discount: " + discount + "%");
        }
}
