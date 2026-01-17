using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.TrafficManagementSystem
{
    public class RunTrafficApp
    {
        public static void MainTraffic()
        {
            ITrafficManager manager = new TrafficManagerImpl();
            bool running = true;

            Console.WriteLine("=== SMART CITY ROUNDABOUT ===");

            while (running)
            {
                TrafficUtility.ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        manager.AddToQueue(TrafficUtility.GetId());
                        break;
                    case "2":
                        manager.MoveToRoundabout();
                        break;
                    case "3":
                        manager.ExitRoundabout(TrafficUtility.GetId());
                        break;
                    case "4":
                        manager.ShowState();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }
    }
}

