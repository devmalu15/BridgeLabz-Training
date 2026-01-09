using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.ATMDispenser
{
    public interface IDispensable
    {
        public void Dispense(ATM atm, int amount);
    }
}
