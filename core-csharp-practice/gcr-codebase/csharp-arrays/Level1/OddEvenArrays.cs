using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level1Array
{
    public class OddEvenArrays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Error: Not a natural number.");
                return;
            }

            int size = (number / 2) + 1;
            int[] evenArray = new int[size];
            int[] oddArray = new int[size];

            int evenIndex = 0;
            int oddIndex = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenArray[evenIndex] = i;
                    evenIndex++;
                }
                else
                {
                    oddArray[oddIndex] = i;
                    oddIndex++;
                }
            }

            Console.WriteLine("Odd Numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.Write(oddArray[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Even Numbers:");
            for (int i = 0; i < evenIndex; i++)
            {
                Console.Write(evenArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
