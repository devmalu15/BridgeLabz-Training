using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.String.Built_in.Problem_Statement
{
    public class Factorial
    {
        static int FindFactorial(int n)
        {
            if (n == 0) return 1;
            return n * FindFactorial(n - 1);
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial: " + FindFactorial(n));
        }
    }
}
