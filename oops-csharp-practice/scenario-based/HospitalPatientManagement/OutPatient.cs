using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.HospitalPatientManagement
{
    public class OutPatient : Patient
    {
        public String appointment;

        public OutPatient(String appointment, String patientName, String patientId) : base(patientName, patientId)
        {
            this.appointment = appointment;
        }
    }
}
