using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.keywords
{
    public class HospitalManagementSystem
    {
        static string hospitalName = "City Care Hospital";
        static int totalPatients = 0;
        string name;
        int age;
        string ailment;
        readonly int patientID;

        public HospitalManagementSystem(string name, int age, string ailment, int patientID)
        {
            this.name = name;
            this.age = age;
            this.ailment = ailment;
            this.patientID = patientID;
            totalPatients++;
        }

        public static int GetTotalPatients()
        {
            return totalPatients;
        }

        public static void Main(string[] args)
        {
            HospitalManagementSystem p1 = new HospitalManagementSystem("Mike", 30, "Flu", 501);

            if (p1 is HospitalManagementSystem)
            {
                Console.WriteLine("Object is of type Patient.");
                Console.WriteLine("Hospital: " + hospitalName);
                Console.WriteLine("Patient Name: " + p1.name);
                Console.WriteLine("Patient ID: " + p1.patientID);
            }

            Console.WriteLine("Total Patients Admitted: " + GetTotalPatients());
        }
    }
}
