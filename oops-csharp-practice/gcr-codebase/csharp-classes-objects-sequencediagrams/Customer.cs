using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ClassesObjectsAndSequenceDiagram
{
    public class Customer
    {
        public string customerName;
        public Product[] cart;
        public int itemCount;

        public Customer(string customerName, int cartSize)
        {
            this.customerName = customerName;
            this.cart = new Product[cartSize];
            this.itemCount = 0;
        }

        public void AddToCart(string item, double qty, double price)
        {
            if (itemCount < cart.Length)
            {
                cart[itemCount] = new Product(item, qty, price);
                itemCount++;
            }
        }
    }
}
