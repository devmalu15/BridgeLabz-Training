using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Sorting
{
    public class InsertionSort
    {
        public static void Main(String[] args)
        {
            int[] ids = { 502, 104, 305, 201, 400 };
            int n = ids.Length;

            for (int i = 1; i < n; i++)
            {
                int key = ids[i];
                int j = i - 1;

                while (j >= 0 && ids[j] > key)
                {
                    ids[j + 1] = ids[j];
                    j = j - 1;
                }
                ids[j + 1] = key;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(ids[i] + " ");
            }
        }
    }
}
