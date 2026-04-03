using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Searching
{
    public class FindRotationPoint
    {
        public static void Main(string[] args)
        {
            int[] rotatedArr = { 4, 5, 6, 7, 0, 1, 2 };
            int index = RotationPointFinder(rotatedArr);
            Console.WriteLine("Rotation point is at index: " + index);
        }

        public static int RotationPointFinder(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] > nums[right])
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
