using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.LibraryManagementSystem
{
    public class LibraryList
    {
        public Node Head;

        public void AddBook(string title, string author, string genre, int id, string status)
        {
            Node newNode = new Node(title, author, genre, id, status);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Prev = temp;
        }

        public void RemoveByID(int id)
        {
            if (Head == null) return;
            if (Head.BookID == id)
            {
                Head = Head.Next;
                if (Head != null) Head.Prev = null;
                return;
            }
            Node temp = Head;
            while (temp != null && temp.BookID != id)
            {
                temp = temp.Next;
            }
            if (temp != null)
            {
                if (temp.Next != null) temp.Next.Prev = temp.Prev;
                if (temp.Prev != null) temp.Prev.Next = temp.Next;
            }
        }

        public void Search(string query)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Title == query || temp.Author == query)
                {
                    Console.WriteLine("Found: " + temp.Title);
                }
                temp = temp.Next;
            }
        }

        public void UpdateStatus(int id, string status)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.BookID == id)
                {
                    temp.Status = status;
                    return;
                }
                temp = temp.Next;
            }
        }

        public void DisplayAll()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Title + " (" + temp.Status + ")");
                temp = temp.Next;
            }
        }

        public void CountBooks()
        {
            int count = 0;
            Node temp = Head;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            Console.WriteLine("Total Books: " + count);
        }
    }
}
