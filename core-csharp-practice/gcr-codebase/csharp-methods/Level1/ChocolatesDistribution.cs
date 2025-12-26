using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods
{
    public class ChocolatesDistribution
    {
        // find chocolates per child and remaining chocolates
        public static int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
        {
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;

            return new int[] { chocolatesPerChild, remainingChocolates };
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number of chocolates: ");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of children: ");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());

            int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

            Console.WriteLine("Each child gets: " + result[0] + " chocolates");
            Console.WriteLine("Remaining chocolates: " + result[1]);
        }
    }
}
