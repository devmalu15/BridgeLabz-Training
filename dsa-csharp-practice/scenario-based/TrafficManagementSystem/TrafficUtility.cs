using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.TrafficManagementSystem
{
    public class TrafficUtility
    {
        public static void ShowMenu()
        {
            Console.WriteLine("1. Add Car to Queue");
            Console.WriteLine("2. Move Car to Roundabout");
            Console.WriteLine("3. Car Exits Roundabout");
            Console.WriteLine("4. Show Status");
            Console.WriteLine("5. Exit");
            Console.Write("Select: ");
        }

        public static int GetId()
        {
            Console.Write("    Enter Vehicle ID: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
