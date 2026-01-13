using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.FinlyTech.LoanBuddy
{
    public class Applicant
    {
        public String name { get; set; }
        public int creditScore { get; set; }
        public int loanAmount { get; set; }
        public int income { get; set; }

        public Applicant(String name, int creditScore, int loanAmount, int income)
        {
            this.name = name;
            this.creditScore = creditScore;
            this.loanAmount = loanAmount;
            this.income = income;

        }
       
    }
}
