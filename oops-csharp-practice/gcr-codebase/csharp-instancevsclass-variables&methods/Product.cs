using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.InstanceVsClassVariablesAndMethods
{
    public class Product
    {
        string productName;
        double price;
        static int totalProducts = 0;

        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine("Product: " + productName);
            Console.WriteLine("Price: " + price);
        }

        public static void DisplayTotalProducts()
        {
            Console.WriteLine("Total Products Created: " + totalProducts);
        }

        public static void Main(string[] args)
        {
            Product p1 = new Product("Laptop", 50000);
            Product p2 = new Product("Mouse", 500);
            p1.DisplayProductDetails();
            DisplayTotalProducts();
        }
    }
}
