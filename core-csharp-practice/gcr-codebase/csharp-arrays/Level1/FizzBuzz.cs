using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level1Array
{
    public class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                string[] results = new string[number];

                for (int i = 1; i <= number; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        results[i - 1] = "FizzBuzz";
                    }
                    else if (i % 3 == 0)
                    {
                        results[i - 1] = "Fizz";
                    }
                    else if (i % 5 == 0)
                    {
                        results[i - 1] = "Buzz";
                    }
                    else
                    {
                        results[i - 1] = i.ToString();
                    }
                }

                for (int i = 0; i < results.Length; i++)
                {
                    Console.WriteLine("Position " + (i + 1) + " = " + results[i]);
                }
            }
        }
    }
}
