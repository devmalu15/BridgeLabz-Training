using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Searching
{
    public class FindPeakElement
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 1, 3, 5, 6, 4 };
            int peakIndex = PeakElementFinder(nums);
            Console.WriteLine("Peak element found at index: " + peakIndex);
        }

        public static int PeakElementFinder(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] < nums[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
    }
}
