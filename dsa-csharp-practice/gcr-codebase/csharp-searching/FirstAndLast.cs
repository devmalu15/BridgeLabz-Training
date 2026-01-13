using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Searching
{
    public class FirstAndLast
    {
        public static void Main(string[] args)
        {
            int[] nums = { 5, 7, 7, 8, 8, 8, 10 };
            int target = 8;
            int[] result = FindFirstAndLast(nums, target);
            Console.WriteLine("First Index: " + result[0] + ", Last Index: " + result[1]);
        }

        public static int[] FindFirstAndLast(int[] nums, int target)
        {
            int first = FindBound(nums, target, true);

            if (first == -1)
            {
                int[] notFound = { -1, -1 };
                return notFound;
            }

            int last = FindBound(nums, target, false);
            int[] found = { first, last };
            return found;
        }

        public static int FindBound(int[] nums, int target, bool isFirst)
        {
            int left = 0, right = nums.Length - 1;
            int boundary = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    boundary = mid;
                    if (isFirst) right = mid - 1;
                    else left = mid + 1;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return boundary;
        }
    }
}
