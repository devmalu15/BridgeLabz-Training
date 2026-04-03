using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased
{
    public class BusRoute
    {
        public static void Main(string[] args)
        {
            int total = 0;
            string ans = "";

            Console.WriteLine("Bus Journey Started");

            while (ans != "yes")
            {
                Console.Write("Enter distance to next stop (km): ");
                int dist = int.Parse(Console.ReadLine());

                total += dist;
                Console.WriteLine("Total distance covered: " + total + " km");

                Console.Write("Do you want to get off here? (yes/no): ");
                ans = Console.ReadLine();
            }

            Console.WriteLine("You arrived. Final distance: " + total + " km");
        }
    }
}
