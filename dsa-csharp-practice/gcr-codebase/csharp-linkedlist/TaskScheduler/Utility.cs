using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.TaskScheduler
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            CircularList list = new CircularList();
            list.AddAtEnd(1, "Design DB", 1, "2023-10-01");
            list.AddAtEnd(2, "Create API", 2, "2023-10-02");
            list.AddAtBeginning(0, "Setup Env", 1, "2023-09-30");

            Console.WriteLine("All Tasks:");
            list.DisplayAll();

            Console.WriteLine("\nExecuting Tasks Round Robin:");
            Node current = list.Head;
            list.ViewCurrentAndMove(ref current);
            list.ViewCurrentAndMove(ref current);
            list.ViewCurrentAndMove(ref current);
            list.ViewCurrentAndMove(ref current);

            Console.WriteLine("\nRemoving Task 1 and Searching Priority 2:");
            list.RemoveByID(1);
            list.SearchByPriority(2);
            list.DisplayAll();
        }
    }
}

