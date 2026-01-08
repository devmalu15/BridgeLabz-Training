using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.UndoRedoEditor
{
    public class Node
    {
        public string State;
        public Node Next;
        public Node Prev;

        public Node(string state)
        {
            State = state;
            Next = null;
            Prev = null;
        }
    }
}
