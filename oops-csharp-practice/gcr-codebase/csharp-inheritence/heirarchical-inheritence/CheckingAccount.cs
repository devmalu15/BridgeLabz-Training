using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.HeirarchicalInheritence
{
    public class CheckingAccount : BankAccount
    {
        public double withdrawalLimit;
        public void DisplayAccountType()
        {
            Console.WriteLine("Checking Account - Balance: " + balance + " Limit: " + withdrawalLimit);
        }
    }
}
