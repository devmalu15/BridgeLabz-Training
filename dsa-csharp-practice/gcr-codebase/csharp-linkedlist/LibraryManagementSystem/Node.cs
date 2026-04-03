using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.LibraryManagementSystem
{
    public class Node
    {
        public string Title;
        public string Author;
        public string Genre;
        public int BookID;
        public string Status;
        public Node Next;
        public Node Prev;

        public Node(string title, string author, string genre, int id, string status)
        {
            Title = title;
            Author = author;
            Genre = genre;
            BookID = id;
            Status = status;
            Next = null;
            Prev = null;
        }
    }
}
