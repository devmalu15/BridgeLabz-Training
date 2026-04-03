using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.StacksAndQueues
{
    public class PetrolPump
    {
        public int petrol;
        public int distance;

        public PetrolPump(int p, int d)
        {
            petrol = p;
            distance = d;
        }
        

        public static int PrintTour(PetrolPump[] arr, int n)
        {
            int start = 0;
            int deficit = 0;
            int capacity = 0;

            for (int i = 0; i < n; i++)
            {
                capacity += arr[i].petrol - arr[i].distance;
                if (capacity < 0)
                {
                    start = i + 1;
                    deficit += capacity;
                    capacity = 0;
                }
            }
            return (capacity + deficit >= 0) ? start : -1;
        }

        public static void Main(string[] args)
        {
            PetrolPump[] arr = {
                new PetrolPump(4, 6),
                new PetrolPump(6, 5),
                new PetrolPump(7, 3),
                new PetrolPump(4, 5)
            };

            int start = PrintTour(arr, arr.Length);
            Console.WriteLine((start == -1) ? "No solution for Ramaa" : "Ramaa can start at pump index: " + start);
        }
    }
}
