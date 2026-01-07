using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased
{
    public class FestiveLottery
    {
        public static void Main(string[] args)
        {
            string choice = "yes";

            while (choice == "yes")
            {
                Console.Write("Enter your ticket number: ");
                int n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("Invalid ticket number.");
                    continue;
                }

                if (n % 3 == 0 && n % 5 == 0)
                {
                    Console.WriteLine("Congratulations! You win a gift.");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                }

                Console.Write("Any more visitors? (yes/no): ");
                choice = Console.ReadLine();
            }
        }

    }
}
