using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.StacksAndQueues
{
    public class SlidingWindowMaximum
    {
        public static void PrintMax(int[] arr, int n, int k)
        {
            LinkedList<int> deque = new LinkedList<int>();

            for (int i = 0; i < k; ++i)
            {
                while (deque.Count != 0 && arr[i] >= arr[deque.Last.Value])
                {
                    deque.RemoveLast();
                }
                deque.AddLast(i);
            }

            for (int i = k; i < n; ++i)
            {
                Console.Write(arr[deque.First.Value] + " ");

                while (deque.Count != 0 && deque.First.Value <= i - k)
                {
                    deque.RemoveFirst();
                }

                while (deque.Count != 0 && arr[i] >= arr[deque.Last.Value])
                {
                    deque.RemoveLast();
                }
                deque.AddLast(i);
            }
            Console.Write(arr[deque.First.Value]);
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            Console.WriteLine("Maximums for Loveeeesh's Window:");
            PrintMax(arr, arr.Length, k);
            Console.WriteLine();
        }
    }
}
