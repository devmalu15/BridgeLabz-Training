using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.StacksAndQueues
{
    public class SortStackRecursion
    {
        public static void SortedInsert(Stack<int> s, int x)
        {
            if (s.Count == 0 || x > s.Peek())
            {
                s.Push(x);
                return;
            }
            int temp = s.Pop();
            SortedInsert(s, x);
            s.Push(temp);
        }

        public static void Sort(Stack<int> s)
        {
            if (s.Count > 0)
            {
                int x = s.Pop();
                Sort(s);
                SortedInsert(s, x);
            }
        }
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(30);
            stack.Push(10);
            stack.Push(50);
            stack.Push(20);
            stack.Push(40);

            Console.WriteLine("Original Stack for Ramaa:");
            foreach (int i in stack) Console.Write(i + " ");


            Console.WriteLine("\nSorted Stack for Ramaa:");
            foreach (int i in stack) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
    
