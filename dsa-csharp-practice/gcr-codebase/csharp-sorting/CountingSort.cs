using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Sorting
{
    public class CountingSort
    {
        public static void Main(String[] args)
        {
            int[] ages = { 14, 12, 15, 12, 14, 18, 10 };
            int n = ages.Length;
            int max = 18;

            int[] output = new int[n];
            int[] count = new int[max + 1];

            for (int i = 0; i < n; i++)
            {
                count[ages[i]]++;
            }

            for (int i = 1; i <= max; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[ages[i]] - 1] = ages[i];
                count[ages[i]]--;
            }

            for (int i = 0; i < n; i++)
            {
                ages[i] = output[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(ages[i] + " ");
            }
        }
    }
}
