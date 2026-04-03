using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Sorting
{
    public class SelectionSort
    {
        public static void Main(String[] args)
        {
            int[] scores = { 78, 92, 45, 88, 60 };
            int n = scores.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = scores[minIndex];
                scores[minIndex] = scores[i];
                scores[i] = temp;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(scores[i] + " ");
            }
        }
    }
}
