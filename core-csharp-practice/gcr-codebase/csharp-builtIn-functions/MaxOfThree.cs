using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.String.Built_in.Problem_Statement
{
    public class MaxOfThree
    {
        static int FindMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static void Main()
        {
            Console.Write("Enter three numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maximum: " + FindMax(a, b, c));
        }
    }
}
