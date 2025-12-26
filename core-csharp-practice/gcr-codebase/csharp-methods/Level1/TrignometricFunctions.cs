using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods
{
    using System;

    namespace BridgeLabz_Training.Methods
    {
        public class TrigonometricFunctions
        {
            //calculate sine, cosine, and tangent
            public static double[] CalculateTrigonometricFunctions(double angle)
            {
                // Convert degrees to radians
                double radians = angle * Math.PI / 180;

                double sine = Math.Sin(radians);
                double cosine = Math.Cos(radians);
                double tangent = Math.Tan(radians);

                return new double[] { sine, cosine, tangent };
            }
            static void Main(string[] args)
            {
                Console.Write("Enter angle in degrees: ");
                double angle = Convert.ToDouble(Console.ReadLine());
                double[] result = CalculateTrigonometricFunctions(angle);
                Console.WriteLine("Sine value: " + result[0]);
                Console.WriteLine("Cosine value: " + result[1]);
                Console.WriteLine("Tangent value: " + result[2]);
            }
        }
    }

}
