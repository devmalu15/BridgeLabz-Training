using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.MultiLevelInheritence
{
    public class DeliveredOrder : ShippedOrder
    {
        public string deliveryDate;

        public void GetOrderStatus()
        {
            Console.WriteLine("Order ID: " + orderId);
            Console.WriteLine("Placed: " + orderDate);
            Console.WriteLine("Tracking: " + trackingNumber);
            Console.WriteLine("Delivered: " + deliveryDate);
        }
    }
}
