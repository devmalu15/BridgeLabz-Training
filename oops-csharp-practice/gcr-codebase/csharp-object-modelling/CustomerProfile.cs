using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ObjectModelling
{
    public class CustomerProfile
    {
        public string Name;
        public List<Order> Orders = new List<Order>();

        public CustomerProfile(string name) { Name = name; }

        public void PlaceOrder(Order o)
        {
            Orders.Add(o);
            Console.WriteLine(Name + " placed order #" + o.OrderId);
        }
    }
}
