using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.RoundsRobinScheduling
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            SchedulerList list = new SchedulerList();
            list.AddProcess(1, 10, 1);
            list.AddProcess(2, 5, 2);
            list.AddProcess(3, 8, 1);

            Console.WriteLine("Initial Processes:");
            list.DisplayAll();

            Console.WriteLine("\nStarting Round Robin Simulation (Quantum = 3):");
            list.SimulateRoundRobin(3);
        }
    }
}
