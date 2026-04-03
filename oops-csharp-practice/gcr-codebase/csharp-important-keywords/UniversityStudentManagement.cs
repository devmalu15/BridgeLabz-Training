using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.keywords
{
    public class UniversityStudentManagement
    {
        static string universityName = "BridgeLabs University";
        static int studentCount = 0;
        string name;
        string grade;
        readonly int rollNumber;

        public UniversityStudentManagement(string name, string grade, int rollNumber)
        {
            this.name = name;
            this.grade = grade;
            this.rollNumber = rollNumber;
            studentCount++;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students: " + studentCount);
        }

        public static void Main(string[] args)
        {
            UniversityStudentManagement s1 = new UniversityStudentManagement("abc", "A", 1001);
            UniversityStudentManagement s2 = new UniversityStudentManagement("cde", "B", 1002);

            if (s1 is UniversityStudentManagement)
            {
                Console.WriteLine("Object is a Student instance.");
                Console.WriteLine("University: " + universityName);
                Console.WriteLine("Student Name: " + s1.name);
            }

            DisplayTotalStudents();
        }
}
