using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.MultiLevelInheritence
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            DeliveredOrder myOrder = new DeliveredOrder();
            myOrder.orderId = 505;
            myOrder.orderDate = "01-Jan-2024";
            myOrder.trackingNumber = "TRK98765";
            myOrder.deliveryDate = "05-Jan-2024";
            myOrder.GetOrderStatus();

            Console.WriteLine("----------------");

            PaidOnlineCourse c = new PaidOnlineCourse();
            c.courseName = "Web Dev";
            c.platform = "Udemy";
            c.fee = 100.0;
            c.discount = 20.0;
            c.ShowDetails();
        }
    }
}
