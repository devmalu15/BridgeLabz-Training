using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.AccessModifiers
{
    public class SavingsAccount : BankAccount
    {
        public void SetupAccount(string accNum, string holder)
        {
            accountNumber = accNum;
            accountHolder = holder;
            Console.WriteLine("Account Holder: " + accountHolder);
        }
    }
}
