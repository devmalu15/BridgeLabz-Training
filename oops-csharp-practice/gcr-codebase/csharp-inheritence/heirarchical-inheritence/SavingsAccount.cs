using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.HeirarchicalInheritence
{
    public class SavingsAccount : BankAccount
    {
        public double interestRate;
        public void DisplayAccountType()
        {
            Console.WriteLine("Savings Account - Balance: " + balance + " Interest: " + interestRate + "%");
        }
    }
}
