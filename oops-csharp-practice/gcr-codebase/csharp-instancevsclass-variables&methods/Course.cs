using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.InstanceVsClassVariablesAndMethods
{
    public class Course
    {
        string courseName;
        int duration;
        double fee;
        static string instituteName = "Tech Institute";

        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        public void DisplayCourseDetails()
        {
            Console.WriteLine("Institute: " + instituteName);
            Console.WriteLine("Course: " + courseName);
        }

        public static void UpdateInstituteName(string newName)
        {
            instituteName = newName;
        }

        public static void Main(string[] args)
        {
            Course c1 = new Course("Java", 3, 15000);
            UpdateInstituteName("Code Academy");
            c1.DisplayCourseDetails();
        }
    }
}
