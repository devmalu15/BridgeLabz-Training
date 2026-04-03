using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.TaskScheduler
{
    public class CircularList
    {
        public Node Head;

        public void AddAtBeginning(int id, string name, int priority, string date)
        {
            Node newNode = new Node(id, name, priority, date);
            if (Head == null)
            {
                Head = newNode;
                newNode.Next = Head;
                return;
            }
            Node temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next;
            }
            newNode.Next = Head;
            temp.Next = newNode;
            Head = newNode;
        }

        public void AddAtEnd(int id, string name, int priority, string date)
        {
            Node newNode = new Node(id, name, priority, date);
            if (Head == null)
            {
                Head = newNode;
                newNode.Next = Head;
                return;
            }
            Node temp = Head;
            while (temp.Next != Head)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Next = Head;
        }

        public void AddAtPosition(int position, int id, string name, int priority, string date)
        {
            if (position == 0)
            {
                AddAtBeginning(id, name, priority, date);
                return;
            }
            Node newNode = new Node(id, name, priority, date);
            Node temp = Head;
            for (int i = 0; i < position - 1; i++)
            {
                temp = temp.Next;
                if (temp == Head) return;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        public void RemoveByID(int id)
        {
            if (Head == null) return;
            if (Head.TaskID == id && Head.Next == Head)
            {
                Head = null;
                return;
            }
            if (Head.TaskID == id)
            {
                Node temp = Head;
                while (temp.Next != Head)
                {
                    temp = temp.Next;
                }
                temp.Next = Head.Next;
                Head = Head.Next;
                return;
            }
            Node curr = Head;
            while (curr.Next != Head && curr.Next.TaskID != id)
            {
                curr = curr.Next;
            }
            if (curr.Next.TaskID == id)
            {
                curr.Next = curr.Next.Next;
            }
        }

        public void ViewCurrentAndMove(ref Node current)
        {
            if (current == null) current = Head;
            if (current != null)
            {
                Console.WriteLine("Current Task: " + current.TaskName);
                current = current.Next;
            }
        }

        public void DisplayAll()
        {
            if (Head == null) return;
            Node temp = Head;
            do
            {
                Console.WriteLine("ID: " + temp.TaskID + ", Name: " + temp.TaskName);
                temp = temp.Next;
            } while (temp != Head);
        }

        public void SearchByPriority(int priority)
        {
            if (Head == null) return;
            Node temp = Head;
            do
            {
                if (temp.Priority == priority)
                {
                    Console.WriteLine("Found Task: " + temp.TaskName);
                }
                temp = temp.Next;
            } while (temp != Head);
        }
    }
}
