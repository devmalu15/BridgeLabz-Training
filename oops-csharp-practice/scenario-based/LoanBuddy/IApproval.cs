using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.FinlyTech.LoanBuddy
{
    public interface IApproval
    {
        public bool ApproveLoan(LoanApplication loanApplication, Loan loan);

        public int CalculateEMI(LoanApplication loanApplication);
    }
}
