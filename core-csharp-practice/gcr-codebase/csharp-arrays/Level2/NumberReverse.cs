using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level2Array
{
    public class NumberReverse
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

            long[] reverseDigits = new long[count];
            for (int i = 0; i < count; i++)
            {
                reverseDigits[i] = digits[i];
            }

            Console.Write("Reverse array: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(reverseDigits[i]);
            }
            Console.WriteLine();
        }
    }
}
