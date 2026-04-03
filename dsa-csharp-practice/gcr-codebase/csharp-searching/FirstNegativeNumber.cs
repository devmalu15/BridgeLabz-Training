using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Searching
{
    public class FirstNegativeNumber
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 10, 5, 20, -3, 8, -1, 4 };
            int result = FindFirstNegative(numbers);

            if (result != 0)
                Console.WriteLine("First negative number is: " + result);
            else
                Console.WriteLine("No negative number found.");
        }

        public static int FindFirstNegative(int[] arr)
        {
            foreach (int num in arr)
            {
                if (num < 0)
                {
                    return num;
                }
            }
            return 0; // Return 0 if no negative number is found
        }
    }
}
