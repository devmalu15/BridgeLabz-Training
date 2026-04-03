using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level2Array
{
    public class StudentGrades
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[] physics = new int[n];
            int[] chemistry = new int[n];
            int[] maths = new int[n];
            double[] percentages = new double[n];
            char[] grades = new char[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter marks for student " + (i + 1));

                Console.Write("Physics: ");
                int p = int.Parse(Console.ReadLine());
                if (p < 0) { Console.WriteLine("Positive marks only."); i--; continue; }
                physics[i] = p;

                Console.Write("Chemistry: ");
                int c = int.Parse(Console.ReadLine());
                if (c < 0) { Console.WriteLine("Positive marks only."); i--; continue; }
                chemistry[i] = c;

                Console.Write("Maths: ");
                int m = int.Parse(Console.ReadLine());
                if (m < 0) { Console.WriteLine("Positive marks only."); i--; continue; }
                maths[i] = m;

                percentages[i] = (p + c + m) / 3.0;

                if (percentages[i] >= 90) grades[i] = 'A';
                else if (percentages[i] >= 80) grades[i] = 'B';
                else if (percentages[i] >= 70) grades[i] = 'C';
                else if (percentages[i] >= 60) grades[i] = 'D';
                else grades[i] = 'F';
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ": Phy=" + physics[i] + " Chem=" + chemistry[i] + " Math=" + maths[i] + " %=" + percentages[i].ToString("F2") + " Grade=" + grades[i]);
            }
        }
    }
}
