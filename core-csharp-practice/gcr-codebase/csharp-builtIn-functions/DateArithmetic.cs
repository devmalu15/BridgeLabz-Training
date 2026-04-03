using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.String.Built_in.Practice
{
    public class DateArithmetic
    {
        static void Main()
        {
            Console.Write("Enter a date (yyyy-MM-dd): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            DateTime result = date
                .AddDays(7)
                .AddMonths(1)
                .AddYears(2)
                .AddDays(-21);

            Console.WriteLine("Final Date: " + result.ToShortDateString());
        }
    }
}
