using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased
{
     public class TemperatureAnalysis
    {
        static int[,] tempRecord = new int[7, 24]

   
{
    // Day 1
    { 20, 19, 19, 18, 18, 19, 21, 23, 25, 27, 29, 31, 33, 34, 34, 33, 32, 30, 28, 27, 25, 24, 23, 22 },
    // Day 2
    { 21, 20, 19, 19, 18, 18, 20, 22, 24, 26, 28, 30, 32, 33, 33, 32, 31, 29, 27, 26, 25, 24, 23, 22 },
    // Day 3
    { 21, 20, 20, 19, 19, 20, 22, 24, 26, 29, 31, 33, 35, 36, 36, 35, 33, 31, 29, 28, 26, 25, 24, 23 },
    // Day 4 (Cooler day)
    { 22, 21, 21, 20, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 29, 28, 27, 26, 25, 24, 23, 22, 21, 21 },
    // Day 5
    { 20, 19, 18, 18, 17, 18, 20, 22, 25, 28, 30, 32, 34, 35, 35, 34, 32, 30, 28, 26, 24, 23, 22, 21 },
    // Day 6
    { 21, 20, 19, 19, 18, 19, 21, 23, 26, 28, 30, 32, 33, 34, 34, 33, 31, 29, 27, 26, 25, 23, 22, 21 },
    // Day 7
    { 20, 19, 19, 18, 18, 19, 21, 24, 26, 29, 31, 33, 35, 36, 35, 34, 32, 30, 28, 27, 25, 24, 23, 22 }
};


        public static int[] AverageTemp(int[,] arr)
        {
            int sum = 0;
            int avg = 0;
            int[] avgTempRecord = new int[7];
            for (int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 24; j++)
                {
                    sum = sum + arr[i, j];
                }
                avg = sum / 24;
                avgTempRecord[i] = avg;
                sum = 0;
                avg = 0;
            }

            return avgTempRecord;
            
        }

        public static String CompareTemp(int[] arr)
        {
            int maxTemp = int.MinValue;
            int minTemp = int.MaxValue;

            int minDay = 10;
            int maxDay = 10;

            for(int i = 0; i < 7; i++)
            {
                if (arr[i] < minTemp)
                {
                    minTemp = arr[i];
                    minDay = i;
                }
                if (arr[i] > maxTemp)
                {
                    maxTemp = arr[i];
                    maxDay = i;
                }
            }

            return "Max Temp: " + maxTemp + "°C (Day " + (maxDay + 1) + ")\n" +
                   "Min Temp: " + minTemp + "°C (Day " + (minDay + 1) + ")";


        }
        public static void DisplayMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n==========================================");
                Console.WriteLine("       WEEKLY TEMPERATURE ANALYZER        ");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. Show Average Temperature per Day");
                Console.WriteLine("2. Show Hottest and Coldest Days");
                Console.WriteLine("3. View Raw Data (First 5 hours)");
                Console.WriteLine("4. Exit");
                Console.WriteLine("------------------------------------------");
                Console.Write("Enter choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n--- Daily Averages ---");
                        int[] averages = AverageTemp(tempRecord);
                        for (int i = 0; i < averages.Length; i++)
                        {
                            Console.WriteLine($"Day {i + 1}: {averages[i]}°C");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n--- Temperature Extremes ---");
                        // We must pass the calculated averages to CompareTemp
                        int[] avgs = AverageTemp(tempRecord);
                        Console.WriteLine(CompareTemp(avgs));
                        break;

                    case "3":
                        Console.WriteLine("\n--- Raw Data Preview (First 5 Hours) ---");
                        for (int i = 0; i < 7; i++)
                        {
                            Console.Write($"Day {i + 1}: ");
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write(tempRecord[i, j] + " ");
                            }
                            Console.WriteLine("...");
                        }
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        public static void Main(String[] args)
        {
            DisplayMenu();

        }
    }
}
