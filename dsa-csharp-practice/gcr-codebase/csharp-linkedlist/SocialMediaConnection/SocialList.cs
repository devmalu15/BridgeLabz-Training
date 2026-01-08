using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.SocialMediaConnection
{
    public class SocialList
    {
        public Node Head;

        public void AddUser(int id, string name, int age)
        {
            Node newNode = new Node(id, name, age);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddFriend(int id1, int id2)
        {
            Node u1 = FindUser(id1);
            Node u2 = FindUser(id2);
            if (u1 != null && u2 != null)
            {
                if (!u1.FriendIDs.Contains(id2)) u1.FriendIDs.Add(id2);
                if (!u2.FriendIDs.Contains(id1)) u2.FriendIDs.Add(id1);
            }
        }

        public Node FindUser(int id)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.UserID == id) return temp;
                temp = temp.Next;
            }
            return null;
        }

        public void DisplayFriends(int id)
        {
            Node u = FindUser(id);
            if (u != null)
            {
                Console.Write("Friends of " + u.Name + ": ");
                foreach (int fid in u.FriendIDs)
                {
                    Node friend = FindUser(fid);
                    if (friend != null) Console.Write(friend.Name + " ");
                }
                Console.WriteLine();
            }
        }

        public void FindMutual(int id1, int id2)
        {
            Node u1 = FindUser(id1);
            Node u2 = FindUser(id2);
            if (u1 != null && u2 != null)
            {
                Console.Write("Mutuals between " + u1.Name + " and " + u2.Name + ": ");
                foreach (int fid in u1.FriendIDs)
                {
                    if (u2.FriendIDs.Contains(fid))
                    {
                        Node mutual = FindUser(fid);
                        if (mutual != null) Console.Write(mutual.Name + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
