using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.ScenarioBased.BankProblem;

namespace BridgeLabsTrainingVS.ScenarioBased.Bank
{
    public class Bank
    {
        String bankName;
        int numOfBranches;
        int bankCode;
        Branch[] branches;

        public Bank(String bankName, int numOfBranches, int bankCode)
        {
            this.bankName = bankName;
            this.numOfBranches = numOfBranches;
            this.bankCode = bankCode;
            this.branches = new Branch[100];
        }


        public Branch[] getBranches()
        {
            return this.branches;
        }

        public void setBranches(Branch branch)
        {
            this.branches.Append(branch);
        }

        public String getName()
        {
            return this.bankName;
        }



    }
}
