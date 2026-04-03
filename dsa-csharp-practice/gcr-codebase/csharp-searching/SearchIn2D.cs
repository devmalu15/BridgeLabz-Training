using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Searching
{
    public class SearchIn2D
    {
        public static void Main(string[] args)
        {
            int[,] matrix = {
            { 1, 3, 5, 7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 60 }
        };

            int target = 16;
            bool exists = SearchMatrix(matrix, target);
            Console.WriteLine("Target exists in matrix: " + exists);
        }

        public static bool SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int left = 0;
            int right = rows * cols - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midValue = matrix[mid / cols, mid % cols];

                if (midValue == target) return true;
                else if (midValue < target) left = mid + 1;
                else right = mid - 1;
            }

            return false;
        }
    }
}
