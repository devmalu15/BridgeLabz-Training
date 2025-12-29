using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.String.Built_in.Practice
{
    public class TimeZones
    {
        static void Main()
        {
            DateTimeOffset utcTime = DateTimeOffset.UtcNow;

            TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            Console.WriteLine("GMT : " + utcTime);
            Console.WriteLine("IST : " + TimeZoneInfo.ConvertTime(utcTime, ist));
            Console.WriteLine("PST : " + TimeZoneInfo.ConvertTime(utcTime, pst));
        }
    }
}
