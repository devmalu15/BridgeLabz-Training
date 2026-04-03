using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.Browser
{
    public class HistoryNode
    {
        public Page Data;
        public HistoryNode Next;
        public HistoryNode Prev;

        public HistoryNode(Page data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }
}
