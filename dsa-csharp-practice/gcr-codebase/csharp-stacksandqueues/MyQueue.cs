using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.StacksAndQueues
{
    public class MyQueue
    {
        Stack<int> s1 = new Stack<int>();
        Stack<int> s2 = new Stack<int>();

        public void Enqueue(int x)
        {
            s1.Push(x);
        }

        public int Dequeue()
        {
            if (s2.Count == 0)
            {
                if (s1.Count == 0)
                {
                    Console.WriteLine("Queue is empty");
                    return -1;
                }
                while (s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                }
            }
            return s2.Pop();
        }

        public static void Main(string[] args)
        {
            MyQueue q = new MyQueue();
            Console.WriteLine("Processing data for Loveeeesh...");
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            q.Enqueue(40);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
        }
    }
}
