using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.HeirarchicalInheritence
{
    public class FixedDepositAccount : BankAccount
    {
        public void DisplayAccountType()
        {
            Console.WriteLine("Fixed Deposit Account - Balance: " + balance);
        }
    }
}
