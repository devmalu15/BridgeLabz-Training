using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.FinlyTech.LoanBuddy
{
    public class HomeLoan : Loan
    {

        public HomeLoan(int term, double interest, String type) : base(term, interest, type, 400)
        {
            
        }
    }
}
