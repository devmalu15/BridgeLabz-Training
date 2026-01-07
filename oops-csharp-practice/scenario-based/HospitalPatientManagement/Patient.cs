using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.HospitalPatientManagement
{
    public class Patient
    {
        public String patientName;
        public String patientId;

        public Patient(String patientName, String patientId)
        {
            this.patientName = patientName;
            this.patientId = patientId;
        }
    }
}
