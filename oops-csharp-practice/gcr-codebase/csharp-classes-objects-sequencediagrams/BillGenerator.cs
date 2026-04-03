using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ClassesObjectsAndSequenceDiagram
{
    public class BillGenerator
    {
        public void GenerateBill(Customer customer)
        {
            double grandTotal = 0;
            Console.WriteLine("Bill for " + customer.customerName);
            Console.WriteLine("------------------------------");

            for (int i = 0; i < customer.itemCount; i++)
            {
                Product item = customer.cart[i];
                double itemTotal = item.GetTotalCost();
                grandTotal += itemTotal;
                Console.WriteLine(item.productName + " (" + item.quantity + " x $" + item.pricePerUnit + "): $" + itemTotal);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Total Amount Due: $" + grandTotal);
        }

        public static void Main(string[] args)
        {
            Customer alice = new Customer("Alice", 10);
            alice.AddToCart("Apples", 2.0, 3.0);
            alice.AddToCart("Milk", 1.0, 2.0);

            BillGenerator billing = new BillGenerator();
            billing.GenerateBill(alice);
        }
    }
}
