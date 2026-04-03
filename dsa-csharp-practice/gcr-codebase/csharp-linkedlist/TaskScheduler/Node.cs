using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.TaskScheduler
{
    public class Node
    {
        public int TaskID;
        public string TaskName;
        public int Priority;
        public string DueDate;
        public Node Next;

        public Node(int id, string name, int priority, string date)
        {
            TaskID = id;
            TaskName = name;
            Priority = priority;
            DueDate = date;
            Next = null;
        }
    }
}
