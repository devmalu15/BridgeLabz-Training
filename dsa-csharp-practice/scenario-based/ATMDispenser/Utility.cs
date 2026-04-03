using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.ATMDispenser
{
    public class Utility
    {
        public static void Main(String[] args)
        {
            int[] denominations = new int[] {
                500, 1000,
                200, 100,
                100, 100,
                50, 100,
                20, 100,
                10, 100,
                5, 100,
                2, 100,
                1, 100
            };

            ATM atm = new ATM(10000000, denominations);

            IDispensable dispenser = new ATMImpl();

            dispenser.Dispense(atm, 13452);

        }
    }
}
