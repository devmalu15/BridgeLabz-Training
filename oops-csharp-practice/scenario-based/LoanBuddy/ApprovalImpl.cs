using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.FinlyTech.LoanBuddy
{
    public class ApprovalImpl : IApproval
    {

        public bool ApproveLoan(LoanApplication loanApplication, Loan loan)
        {
            if (loanApplication.applicant.income * 2 < loanApplication.applicant.loanAmount || loanApplication.applicant.creditScore < loan.requiredCredits)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int CalculateEMI(LoanApplication loanApplication)
        {

            // getting the principal amount from the applicant details
            double principal = loanApplication.applicant.loanAmount;

            // converting annual interest rate to monthly and then to decimal
            double monthlyRate = (loanApplication.interestRate / 12) / 100;

            // converting the term from years to months
            double months = loanApplication.termYears * 12;

            // calculating the top part of the emi formula
            double numerator = principal * monthlyRate * Math.Pow(1 + monthlyRate, months);

            // calculating the bottom part
            double denominator = Math.Pow(1 + monthlyRate, months) - 1;

            // final calculation and casting it to int to return
            double emi = numerator / denominator;

            return (int)Math.Round(emi);
        }
    }
}
