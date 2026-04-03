using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Inheritence.SingleInheritence
{
    public class Thermostat : Device
    {
        public double temperatureSetting;

        public void DisplayStatus()
        {
            Console.WriteLine("Device ID: " + deviceId);
            Console.WriteLine("Status: " + status);
            Console.WriteLine("Temperature: " + temperatureSetting + "C");
        }
    }
}
