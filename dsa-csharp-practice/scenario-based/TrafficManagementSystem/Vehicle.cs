using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.TrafficManagementSystem
{
    public class Vehicle
    {
        public int Id;
        public Vehicle Next;

        public Vehicle(int id)
        {
            Id = id;
            Next = null;
        }
    }
}
