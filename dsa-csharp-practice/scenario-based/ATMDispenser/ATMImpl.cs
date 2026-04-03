using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.ATMDispenser
{
    public class ATMImpl : IDispensable
    {
        public void Dispense(ATM atm, int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid Amount");
                return;
            }

            Console.WriteLine("Dispensing for Amount: " + amount);

            int tempAmount = amount;

            for (int i = 0; i < atm.denomination.Length; i += 2)
            {
                int noteValue = atm.denomination[i];
                int noteCount = atm.denomination[i + 1];

                if (tempAmount >= noteValue && noteCount > 0)
                {
                    int needed = tempAmount / noteValue;
                    int take = (needed <= noteCount) ? needed : noteCount;

                    if (take > 0)
                    {
                        Console.WriteLine("Note " + noteValue + " : " + take);
                        tempAmount = tempAmount - (take * noteValue);

                        
                        atm.denomination[i + 1] = noteCount - take;
                    }
                }
            }

            if (tempAmount > 0)
            {
                Console.WriteLine("Insufficient funds to dispense remaining: " + tempAmount);
            }
            Console.WriteLine("-----------------------------");
        }
    }
}
