using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level1Array
{
    public class NumberAnalysis
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine(numbers[i] + " is positive and even.");
                    }
                    else
                    {
                        Console.WriteLine(numbers[i] + " is positive and odd.");
                    }
                }
                else if (numbers[i] < 0)
                {
                    Console.WriteLine(numbers[i] + " is negative.");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " is zero.");
                }
            }

            if (numbers[0] == numbers[numbers.Length - 1])
            {
                Console.WriteLine("First and last elements are equal.");
            }
            else if (numbers[0] > numbers[numbers.Length - 1])
            {
                Console.WriteLine("First element is greater than last element.");
            }
            else
            {
                Console.WriteLine("First element is less than last element.");
            }
        }
    }
}
