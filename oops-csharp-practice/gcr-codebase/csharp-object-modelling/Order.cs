using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ObjectModelling
{
    public class Order
    {
        public int OrderId;
        public List<Product> Products = new List<Product>();

        public Order(int id) { OrderId = id; }

        public void AddProduct(Product p)
        {
            Products.Add(p);
        }
    }
}
