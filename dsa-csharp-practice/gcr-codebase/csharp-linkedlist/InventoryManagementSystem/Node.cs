using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.InventoryManagementSystem
{
    public class Node
    {
        public string ItemName;
        public int ItemID;
        public int Quantity;
        public double Price;
        public Node Next;

        public Node(string name, int id, int qty, double price)
        {
            ItemName = name;
            ItemID = id;
            Quantity = qty;
            Price = price;
            Next = null;
        }
    }
}
