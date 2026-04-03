using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Level3Methods
{
    
    public class EuclideanLine
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double distance = CalculateDistance(x1, y1, x2, y2);
            Console.WriteLine("Distance: " + distance);

            double[] equation = FindLineEquation(x1, y1, x2, y2);
            Console.WriteLine("Line Equation: y = " + equation[0] + "x + " + equation[1]);
        }

        static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static double[] FindLineEquation(double x1, double y1, double x2, double y2)
        {
            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - (m * x1);
            double[] result = { m, b };
            return result;
        }
    }
}
