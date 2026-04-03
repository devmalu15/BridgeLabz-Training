using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.ApplianceAutomationSystem
{
    public class Utility
    {
        public static void Main(String[] args)
        {
            AC ac = new AC(12345, 1);
            Fan fan = new Fan(12346, 1);
            Light light = new Light(12347, 1);

            ac.ClickSwitch();
            fan.ClickSwitch();
            light.ClickSwitch();
        }
    }
}
