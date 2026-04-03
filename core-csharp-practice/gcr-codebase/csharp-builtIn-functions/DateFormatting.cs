using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.String.Built_in.Practice
{
    public class DateFormatting
    {
        static void Main()
        {
            DateTime today = DateTime.Now;

            Console.WriteLine(today.ToString("dd/MM/yyyy"));
            Console.WriteLine(today.ToString("yyyy-MM-dd"));
            Console.WriteLine(today.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
