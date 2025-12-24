using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.level2Array
{
    public class StudentGrades2D
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[,] marks = new int[n, 3];
            double[] percentages = new double[n];
            char[] grades = new char[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Student " + (i + 1));

                Console.Write("Physics: ");
                int p = int.Parse(Console.ReadLine());
                if (p < 0) { Console.WriteLine("Invalid marks."); i--; continue; }
                marks[i, 0] = p;

                Console.Write("Chemistry: ");
                int c = int.Parse(Console.ReadLine());
                if (c < 0) { Console.WriteLine("Invalid marks."); i--; continue; }
                marks[i, 1] = c;

                Console.Write("Maths: ");
                int m = int.Parse(Console.ReadLine());
                if (m < 0) { Console.WriteLine("Invalid marks."); i--; continue; }
                marks[i, 2] = m;

                percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

                if (percentages[i] >= 90) grades[i] = 'A';
                else if (percentages[i] >= 80) grades[i] = 'B';
                else if (percentages[i] >= 70) grades[i] = 'C';
                else if (percentages[i] >= 60) grades[i] = 'D';
                else grades[i] = 'F';
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Student " + (i + 1) + " Grade: " + grades[i] + " (" + percentages[i].ToString("F2") + "%)");
            }
        }
    }
}
