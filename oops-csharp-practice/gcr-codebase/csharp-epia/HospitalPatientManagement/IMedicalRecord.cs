using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.HospitalPatientManagement
{
    public interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }
}
