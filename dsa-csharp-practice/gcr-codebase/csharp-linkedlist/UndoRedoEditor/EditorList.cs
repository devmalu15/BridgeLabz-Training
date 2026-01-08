using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.LinkedList.UndoRedoEditor
{
    public class EditorList
    {
        public Node Current;
        public Node Head;
        public int Count;
        public int MaxSize = 10;

        public void AddState(string text)
        {
            Node newNode = new Node(text);
            if (Head == null)
            {
                Head = newNode;
                Current = Head;
                Count = 1;
            }
            else
            {
                if (Current.Next != null)
                {
                    Current.Next = null;
                }
                Current.Next = newNode;
                newNode.Prev = Current;
                Current = newNode;
                Count++;
                if (Count > MaxSize)
                {
                    Head = Head.Next;
                    Head.Prev = null;
                    Count--;
                }
            }
        }

        public void Undo()
        {
            if (Current != null && Current.Prev != null)
            {
                Current = Current.Prev;
                Console.WriteLine("Undo: " + Current.State);
            }
            else
            {
                Console.WriteLine("Cannot Undo further.");
            }
        }

        public void Redo()
        {
            if (Current != null && Current.Next != null)
            {
                Current = Current.Next;
                Console.WriteLine("Redo: " + Current.State);
            }
            else
            {
                Console.WriteLine("Cannot Redo.");
            }
        }

        public void DisplayCurrent()
        {
            if (Current != null) Console.WriteLine("Current Text: " + Current.State);
        }
    }
}
