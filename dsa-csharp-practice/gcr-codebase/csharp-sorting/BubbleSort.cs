using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Sorting
{
    public class BubbleSort
    {
        public static void Main(String[] args)
        {
            int[] marks = { 85, 42, 90, 65, 33 };
            int n = marks.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(marks[i] + " ");
            }
        }
    }
}
