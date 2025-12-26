using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods
{
    public class SumOfNaturalNumbers
    {
        // calculate sum of n natural numbers
        static int FindSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a natural number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = FindSum(n);
            Console.WriteLine("The sum of first " + n + " natural numbers is: " + result);
        }
    }
}
