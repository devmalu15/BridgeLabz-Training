using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.HospitalPatientManagement
{
    abstract class Patient : IMedicalRecord
    {
        private int patientId;
        private string name;
        private int age;
        private string diagnosis;

        private string[] medicalHistory;
        private int recordCount;

        public int PatientId { get { return patientId; } set { patientId = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        protected string Diagnosis { get { return diagnosis; } set { diagnosis = value; } }

        public Patient(int id, string patientName, int patientAge)
        {
            patientId = id;
            name = patientName;
            age = patientAge;
            medicalHistory = new string[10]; // fixed size
            recordCount = 0;
        }

        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine("Patient ID: " + patientId +
                              " | Name: " + name +
                              " | Age: " + age);
        }

        public void AddRecord(string record)
        {
            if (recordCount < medicalHistory.Length)
            {
                medicalHistory[recordCount] = record;
                recordCount++;
                Console.WriteLine("Medical record added");
            }
            else
            {
                Console.WriteLine("Medical history is full");
            }
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical History:");
            for (int i = 0; i < recordCount; i++)
            {
                Console.WriteLine("- " + medicalHistory[i]);
            }
        }
    }
}
