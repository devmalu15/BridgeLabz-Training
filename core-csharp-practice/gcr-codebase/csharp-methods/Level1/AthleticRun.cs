using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods
{
    public class AthleticRun
    {
        static double numberOfRoundsCalculator(double firstSide, double secondSide, double thirdSide)
        {
            double perimeter = firstSide + secondSide + thirdSide;
            double totalDistance = 5000;
            return (totalDistance / perimeter);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first side:");
            double firstSide = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second side:");
            double secondSide = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third side:");
            double thirdSide = Convert.ToDouble(Console.ReadLine());

            double numberOfRounds = numberOfRoundsCalculator(firstSide, secondSide, thirdSide);
            Console.WriteLine("Number of rounds athlete must complete to complete a 5km run is :" + numberOfRounds);
        }
    }
}
