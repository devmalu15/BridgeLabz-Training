using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ClassesObjectsAndSequenceDiagram
{
    public class GradeCalculator
    {
        public void CalculateResult(Student student)
        {
            int totalMarks = 0;
            Console.WriteLine("Result for " + student.studentName);

            for (int i = 0; i < student.subjectCount; i++)
            {
                totalMarks += student.subjects[i].marks;
                Console.WriteLine(student.subjects[i].subjectName + ": " + student.subjects[i].marks);
            }

            double average = totalMarks / (double)student.subjectCount;
            Console.WriteLine("Average Marks: " + average);

            if (average >= 50)
            {
                Console.WriteLine("Grade: Pass");
            }
            else
            {
                Console.WriteLine("Grade: Fail");
            }
        }

        public static void Main(string[] args)
        {
            Student john = new Student("John", 5);
            john.AddSubject("Maths", 90);
            john.AddSubject("Science", 85);

            GradeCalculator calculator = new GradeCalculator();
            calculator.CalculateResult(john);
        }
    }

}
