using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.ApplianceAutomationSystem
{
    public class Fan : Appliance, IControllable
    {
        int fanID;

        public Fan(int applianceID, int fanID): base(applianceID)
        {
            this.fanID = fanID;
        }


        public void ClickSwitch()
        {
            Console.WriteLine("Fan is on! woooooooo");
        }


    }
}
