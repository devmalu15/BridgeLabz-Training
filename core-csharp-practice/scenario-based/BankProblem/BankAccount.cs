using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.ScenarioBased.BankProblem;

namespace BridgeLabsTrainingVS.ScenarioBased.Bank
{
    public class BankAccount
    {
        String bankName;
        String branchName;
        String clientName;
        int clientCode;
        String accNumber;
        String accType;
        String ifscCode;
        int accBalance;
        int fourDigitCode;


        public BankAccount(String clientName, String accType, int fourDigitCode, String bankName, String BranchName)
        {
            Random random = new Random();
            long accNum1 = random.Next(10000000, 99999999);
            long accNum2 = random.Next(10000000, 99999999);
            this.clientName = clientName;
            this.clientCode = random.Next(1000000, 9999999);
            this.accNumber = accNum1.ToString() + " " + accNum2.ToString();
            this.accType = accType;
            this.ifscCode = bankName[0..2] + random.Next(100000, 999999).ToString();
            this.accBalance = 0;
            this.fourDigitCode = fourDigitCode;
        }


        public String getAccNum()
        {
            return this.accNumber;
        }

        public void increaseBalance(int balance)
        {
            this.accBalance = this.accBalance + balance;
        }

        public void decreaseBalance(int balance)
        {
            this.accBalance = this.accBalance - balance;
        }

        public int getAccBalance()
        {
            return this.accBalance;
        }



    }


}
