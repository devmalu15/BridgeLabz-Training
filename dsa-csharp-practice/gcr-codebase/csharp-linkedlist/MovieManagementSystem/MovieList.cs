using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.MovieManagementSystem
{
    public class MovieList
    {
        public Node Head;

        public void AddAtBeginning(string title, string director, int year, double rating)
        {
            Node newNode = new Node(title, director, year, rating);
            if (Head != null)
            {
                Head.Prev = newNode;
            }
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddAtEnd(string title, string director, int year, double rating)
        {
            Node newNode = new Node(title, director, year, rating);
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

        public void AddAtPosition(int position, string title, string director, int year, double rating)
        {
            if (position == 0)
            {
                AddAtBeginning(title, director, year, rating);
                return;
            }
            Node newNode = new Node(title, director, year, rating);
            Node temp = Head;
            for (int i = 0; i < position - 1; i++)
            {
                if (temp == null) return;
                temp = temp.Next;
            }
            if (temp == null) return;
            newNode.Next = temp.Next;
            newNode.Prev = temp;
            if (temp.Next != null)
            {
                temp.Next.Prev = newNode;
            }
            temp.Next = newNode;
        }

        public void RemoveByTitle(string title)
        {
            if (Head == null) return;
            if (Head.Title == title)
            {
                Head = Head.Next;
                if (Head != null) Head.Prev = null;
                return;
            }
            Node temp = Head;
            while (temp != null && temp.Title != title)
            {
                temp = temp.Next;
            }
            if (temp == null) return;
            if (temp.Next != null)
            {
                temp.Next.Prev = temp.Prev;
            }
            if (temp.Prev != null)
            {
                temp.Prev.Next = temp.Next;
            }
        }

        public void Search(string query)
        {
            Node temp = Head;
            bool found = false;
            while (temp != null)
            {
                if (temp.Director == query || temp.Rating.ToString() == query)
                {
                    Console.WriteLine("Found: " + temp.Title);
                    found = true;
                }
                temp = temp.Next;
            }
            if (!found) Console.WriteLine("Movie not found.");
        }

        public void DisplayForward()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Title + " | " + temp.Director + " | " + temp.Rating);
                temp = temp.Next;
            }
        }

        public void DisplayReverse()
        {
            if (Head == null) return;
            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.Title + " | " + temp.Director + " | " + temp.Rating);
                temp = temp.Prev;
            }
        }

        public void UpdateRating(string title, double newRating)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Title == title)
                {
                    temp.Rating = newRating;
                    return;
                }
                temp = temp.Next;
            }
        }
    }
}
