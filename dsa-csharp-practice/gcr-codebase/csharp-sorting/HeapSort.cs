using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Sorting
{
    public class HeapSort
    {
        public static void Main(String[] args)
        {
            int[] salary = { 50000, 120000, 75000, 90000, 45000 };
            int n = salary.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(salary, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                int temp = salary[0];
                salary[0] = salary[i];
                salary[i] = temp;

                Heapify(salary, i, 0);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(salary[i] + " ");
            }
        }

        public static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }
    }
}
