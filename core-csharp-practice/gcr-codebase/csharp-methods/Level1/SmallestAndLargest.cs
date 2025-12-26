using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods
{
    public class SmallestAndLargest
    {
        public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
            int smallest = number1;
            int largest = number1;
            if (number2 < smallest)
            {
                smallest = number2;
            }
            if ((number3 < smallest))
            {
                smallest = number3;
            }
            if (number2 > largest) { 
                largest = number2;
            }
            if (number3 > largest) {
                largest = number3;
            }
            return new int[] { smallest, largest };
            

        }
        static void Main(string[] args)
        {
            Console.Write("Enter Number1 :");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number2 :");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number1 :");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int[] result = FindSmallestAndLargest(number1, number2, number3);

            Console.WriteLine("Smallest of the three numbers is " + result[0]);
            Console.WriteLine("Largest of the three numbers is " + result[1]);
        }
    }
}
