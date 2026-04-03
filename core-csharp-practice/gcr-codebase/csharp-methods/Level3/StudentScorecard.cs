using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Level3Methods
{
    
    public class StudentScorecard
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[,] scores = GenerateScores(n);
            double[,] stats = CalculateStats(scores);

            DisplayScorecard(scores, stats);
        }

        static int[,] GenerateScores(int n)
        {
            Random rand = new Random();
            int[,] data = new int[n, 3];

            for (int i = 0; i < n; i++)
            {
                data[i, 0] = rand.Next(10, 100);
                data[i, 1] = rand.Next(10, 100);
                data[i, 2] = rand.Next(10, 100);
            }
            return data;
        }

        static double[,] CalculateStats(int[,] scores)
        {
            int n = scores.GetLength(0);
            double[,] results = new double[n, 3];

            for (int i = 0; i < n; i++)
            {
                double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
                double average = total / 3.0;
                double percentage = (total / 300.0) * 100;

                results[i, 0] = total;
                results[i, 1] = Math.Round(average, 2);
                results[i, 2] = Math.Round(percentage, 2);
            }
            return results;
        }

        static void DisplayScorecard(int[,] scores, double[,] stats)
        {
            Console.WriteLine("Std\tPhy\tChem\tMath\tTotal\tAvg\t%");
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                Console.WriteLine((i + 1) + "\t" + scores[i, 0] + "\t" + scores[i, 1] + "\t" + scores[i, 2] + "\t" + stats[i, 0] + "\t" + stats[i, 1] + "\t" + stats[i, 2]);
            }
        }
    }
}
