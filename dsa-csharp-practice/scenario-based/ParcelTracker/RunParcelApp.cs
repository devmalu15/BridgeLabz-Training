using System;

public class RunParcelApp
    {
        public static void Main(string[] args)
        {
            IParcelTracker tracker = new ParcelTrackerImpl();
            bool running = true;

            Console.WriteLine("=== PARCEL TRACKER SYSTEM ===");
            
            tracker.AddStage("Packed", "Warehouse A");
            tracker.AddStage("Shipped", "Distribution Center");

            while (running)
            {
                ParcelUtility.ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string s = ParcelUtility.GetString("Status");
                        string l = ParcelUtility.GetString("Location");
                        tracker.AddStage(s, l);
                        break;
                    case "2":
                        string ns = ParcelUtility.GetString("New Status");
                        string nl = ParcelUtility.GetString("New Location");
                        string after = ParcelUtility.GetString("Insert After Status");
                        tracker.InsertCheckpoint(ns, nl, after);
                        break;
                    case "3":
                        tracker.TrackParcel();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }
    }