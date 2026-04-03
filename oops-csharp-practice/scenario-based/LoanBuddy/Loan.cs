using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.FinlyTech.LoanBuddy
{
    public class Loan
    {
        public int term { get; set; }
        public double interest { get; set; }
        public String type { get; set; }
       
        public int requiredCredits { get; set; }

        public Loan(int term, double interest, string type, int requiredCredits)
        {
            this.term = term;
            this.interest = interest;
            this.type = type;
            this.requiredCredits = requiredCredits;
        }
    }
}
