using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level2Array
{
    public class DigitsToArrayDynamic
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            long number = long.Parse(Console.ReadLine());

            int maxDigit = 10;
            long[] digits = new long[maxDigit];
            int index = 0;

            while (number != 0)
            {
                if (index == maxDigit)
                {
                    maxDigit = maxDigit + 10;
                    long[] temp = new long[maxDigit];

                    for (int i = 0; i < digits.Length; i++)
                    {
                        temp[i] = digits[i];
                    }

                    digits = temp;
                }

                digits[index] = number % 10;
                number = number / 10;
                index++;
            }

            long largest = 0;
            long secondLargest = 0;

            for (int i = 0; i < index; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }

            Console.WriteLine("Largest Digit: " + largest);
            Console.WriteLine("Second Largest Digit: " + secondLargest);
        }
    }
}
}
