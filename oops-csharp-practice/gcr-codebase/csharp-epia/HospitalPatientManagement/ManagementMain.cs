using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.HospitalPatientManagement
{
    public class ManagementMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HOSPITAL PATIENT MANAGEMENT ===");
            Console.WriteLine();

            Patient[] patients = new Patient[2];
            patients[0] = new InPatient(101, "abc", 45, 5, 1000);
            patients[1] = new OutPatient(102, "cde", 30, 3);

            Console.WriteLine("=== PATIENT BILLING ===");
            foreach (Patient p in patients)
            {
                p.GetPatientDetails();
                p.AddRecord("Blood test done");
                p.AddRecord("X-ray taken");

                double bill = p.CalculateBill();
                Console.WriteLine("Total Bill: $" + bill);

                p.ViewRecords();

            }
        }

    }
}
