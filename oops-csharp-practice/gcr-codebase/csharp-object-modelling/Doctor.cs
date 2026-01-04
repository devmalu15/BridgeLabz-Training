using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ObjectModelling
{
    public class Doctor
    {
        public string Name;
        public Doctor(string name) { Name = name; }

        public void Consult(Patient p)
        {
            Console.WriteLine("Dr. " + Name + " is consulting patient " + p.Name);
        }
    }
}
