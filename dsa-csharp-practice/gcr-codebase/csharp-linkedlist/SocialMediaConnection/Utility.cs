using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.SocialMediaConnection
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            SocialList list = new SocialList();
            list.AddUser(1, "Loveeeesh", 25);
            list.AddUser(2, "Ramaa", 27);
            list.AddUser(3, "Risita", 22);

            list.AddFriend(1, 2);
            list.AddFriend(1, 3);
            list.AddFriend(2, 3);

            list.DisplayFriends(1);
            list.DisplayFriends(2);

            list.FindMutual(1, 2);
        }
    }
}
