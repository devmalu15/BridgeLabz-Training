using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.FinlyTech.LoanBuddy
{
    public class LoanApplication
    {
        public Applicant applicant { get; set; }
        public String type { get; set; }
        public int termYears { get; set; }
        public double interestRate { get; set; }

        public LoanApplication(Applicant applicant, string type, int termYears, double interestRate)
        {
            this.applicant = applicant;
            this.type = type;
            this.termYears = termYears;
            this.interestRate = interestRate;
        }
    }
}
