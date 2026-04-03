using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level2Array
{
    public class DigitFrequency
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            long number = long.Parse(Console.ReadLine());
            long temp = number;

            int count = 0;
            while (temp > 0)
            {
                temp = temp / 10;
                count++;
            }

            long[] digits = new long[count];
            temp = number;
            for (int i = 0; i < count; i++)
            {
                digits[i] = temp % 10;
                temp = temp / 10;
            }

            int[] frequency = new int[10];

            for (int i = 0; i < digits.Length; i++)
            {
                int digit = (int)digits[i];
                frequency[digit]++;
            }

            Console.WriteLine("Digit Frequencies:");
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine("Digit " + i + ": " + frequency[i] + " times");
                }
            }
        }
    }
}
