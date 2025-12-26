using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods
{
    public class SimpleInterest
    {
        public static double CalculateSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter principal :");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rate :");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter time :");
            double time = Convert.ToDouble(Console.ReadLine());

            double simpleInterestCalculate = CalculateSimpleInterest(principal, rate, time);

            Console.WriteLine("the simple interest is " + simpleInterestCalculate + " for principal " + principal + ", rate of interest " + rate + " and time " + time);
        }
    }
}
