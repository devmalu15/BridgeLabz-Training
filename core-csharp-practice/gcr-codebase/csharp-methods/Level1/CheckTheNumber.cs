using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods
{
    public class CheckTheNumber
    {
        static int NumberChecker(int number)
        {
            if (number < 0)
            {
                return -1;
            }
            else if (number > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
                static void Main(string[] args)
            {
                Console.Write("Enter the number that is to be checked :");
                int number = Convert.ToInt32(Console.ReadLine());

                int result = NumberChecker(number);
                if (result == 1)
                {
                    Console.WriteLine("The number is positive");
                }
                else if (result == -1)
                {
                    Console.WriteLine("The number is negative");
                }
                else
                {
                    Console.WriteLine("The number is zero");
                }

            }
        
    }
}
