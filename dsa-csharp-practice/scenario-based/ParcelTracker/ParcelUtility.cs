using System;

public class ParcelUtility
    {
        public static void ShowMenu()
        {
            Console.WriteLine("1. Update Status (Add Stage)");
            Console.WriteLine("2. Add Intermediate Checkpoint");
            Console.WriteLine("3. Track Parcel");
            Console.WriteLine("4. Exit");
            Console.Write("Select: ");
        }

        public static string GetString(string prompt)
        {
            Console.Write($"    {prompt}: ");
            return Console.ReadLine();
        }
    }