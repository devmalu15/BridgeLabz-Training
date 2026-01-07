using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.HospitalPatientManagement
{
    public class Bill : IPayable
    {
        public void displayStatus(Patient patient)
        {
            if(patient is InPatient InP)
            {
                Console.WriteLine("Patient Name : " + InP.patientName + "/n" + "Patient ID : " + InP.patientId + "/n" + "Bill : " + InP.durationDays * 10000);

            }
            else if (patient is OutPatient OutP)
            {
                Console.WriteLine("Patient Name : " + OutP.patientName + "/n" + "Patient ID : " + OutP.patientId + "/n" + "Appointment Details : " + OutP.appointment);

            }
        }
    }
}
