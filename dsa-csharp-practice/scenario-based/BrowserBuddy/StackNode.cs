using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.Browser
{
    public class StackNode
    {
        public HistoryNode TabState;
        public StackNode Next;

        public StackNode(HistoryNode tabState)
        {
            TabState = tabState;
            Next = null;
        }
    }
}
