using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.ATMDispenser
{
    public class ATM
    {
        public int balance { get; set; }
        public int[] denomination { get; set; }

        public ATM(int balance, int[] denomination)
        {
            this.balance = balance;
            this.denomination = denomination;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
