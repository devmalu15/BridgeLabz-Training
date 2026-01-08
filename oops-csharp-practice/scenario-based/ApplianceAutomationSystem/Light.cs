using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.ApplianceAutomationSystem
{
    public class Light : Appliance, IControllable
    {
        int LightID;

        public Light(int applianceID, int LightID) : base(applianceID)
        {
            this.LightID = LightID;
        }


        public void ClickSwitch()
        {
            Console.WriteLine("Light is on! blink");
        }


    }
}
