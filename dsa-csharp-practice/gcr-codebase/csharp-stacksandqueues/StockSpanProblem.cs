using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.StacksAndQueues
{
    public class StockSpanProblem
    {
        public static void CalculateSpan(int[] price, int n, int[] S)
        {
            Stack<int> st = new Stack<int>();
            st.Push(0);
            S[0] = 1;

            for (int i = 1; i < n; i++)
            {
                while (st.Count > 0 && price[st.Peek()] <= price[i])
                {
                    st.Pop();
                }
                S[i] = st.Count == 0 ? i + 1 : i - st.Peek();
                st.Push(i);
            }
        }

        public static void Main(string[] args)
        {
            int[] price = { 100, 80, 60, 70, 60, 75, 85 };
            int n = price.Length;
            int[] S = new int[n];

            CalculateSpan(price, n, S);

            Console.WriteLine("Stock Spans for Risita's Portfolio:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(S[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
