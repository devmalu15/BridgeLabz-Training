using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods
{
    public class SpringSeason
    {
        // check spring season
        static bool SpringSeasonCheck(int month, int day)
        {
            if ((month == 3 && day >= 20) ||
                (month == 4) ||
                (month == 5) ||
                (month == 6 && day <= 20))
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the month");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the day");
            int day = Convert.ToInt32(Console.ReadLine());

            bool result = SpringSeasonCheck(month, day);

            if (result)
                Console.WriteLine("Its a Spring Season");
            else
                Console.WriteLine("Not a Spring Season");
        }
    }
}
