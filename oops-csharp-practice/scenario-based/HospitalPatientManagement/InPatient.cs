using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.HospitalPatientManagement
{
    public class InPatient : Patient
    {
        public int durationDays;

        public InPatient(int durationDays, String patientName, String patientId) : base(patientName, patientId)
        {
            this.durationDays = durationDays;
        }
    }
}
