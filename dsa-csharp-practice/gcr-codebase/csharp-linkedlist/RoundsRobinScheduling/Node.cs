using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.RoundsRobinScheduling
{
    public class Node
    {
        public int ProcessID;
        public int BurstTime;
        public int Priority;
        public int RemainingTime;
        public int WaitingTime;
        public int TurnAroundTime;
        public Node Next;

        public Node(int id, int burst, int priority)
        {
            ProcessID = id;
            BurstTime = burst;
            RemainingTime = burst;
            Priority = priority;
            WaitingTime = 0;
            TurnAroundTime = 0;
            Next = null;
        }
    }
}
