using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.SocialMediaConnection
{
    public class Node
    {
        public int UserID;
        public string Name;
        public int Age;
        public List<int> FriendIDs;
        public Node Next;

        public Node(int id, string name, int age)
        {
            UserID = id;
            Name = name;
            Age = age;
            FriendIDs = new List<int>();
            Next = null;
        }
    }
}
