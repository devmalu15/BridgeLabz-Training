using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.ApplianceAutomationSystem
{
    public class AC : Appliance, IControllable
    {
        int ACID;

        public AC(int applianceID, int ACID) : base(applianceID)
        {
            this.ACID = ACID;
        }


        public void ClickSwitch()
        {
            Console.WriteLine("AC is on! shshshshhhhh");
        }


    }
}
