using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Sorting
{
    public class MergeSort
    {
        public static void Main(String[] args)
        {
            int[] prices = { 120, 50, 300, 150, 80 };
            Sort(prices, 0, prices.Length - 1);

            for (int i = 0; i < prices.Length; i++)
            {
                Console.Write(prices[i] + " ");
            }
        }

        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArr[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArr[j] = arr[mid + 1 + j];

            int i1 = 0, i2 = 0;
            int k = left;

            while (i1 < n1 && i2 < n2)
            {
                if (leftArr[i1] <= rightArr[i2])
                {
                    arr[k] = leftArr[i1];
                    i1++;
                }
                else
                {
                    arr[k] = rightArr[i2];
                    i2++;
                }
                k++;
            }

            while (i1 < n1)
            {
                arr[k] = leftArr[i1];
                i1++;
                k++;
            }

            while (i2 < n2)
            {
                arr[k] = rightArr[i2];
                i2++;
                k++;
            }
        }
    }
}
