using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Searching
{
    public class FirstMissingPositive
    {
        public static void Main(string[] args)
        {
            // Part 1: First Missing Positive
            int[] nums1 = { 3, 4, -1, 1 };
            Console.WriteLine("First missing positive is: " + MissingPositiveFinder(nums1));

            // Part 2: Binary Search for Target
            int[] nums2 = { 10, 20, 30, 40, 50 };
            int target = 30;
            Console.WriteLine("Target found at index: " + BinarySearch(nums2, target));
        }

        public static int MissingPositiveFinder(int[] nums)
        {
            int n = nums.Length;
            bool oneExists = false;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 1) oneExists = true;
            }

            if (!oneExists) return 1;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] <= 0 || nums[i] > n)
                {
                    nums[i] = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0)
                {
                    nums[index] = -1 * nums[index];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    return i + 1;
                }
            }

            return n + 1;
        }

        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target) return mid;
                if (arr[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
    }
}
