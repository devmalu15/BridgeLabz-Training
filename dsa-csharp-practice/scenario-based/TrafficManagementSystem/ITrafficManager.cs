using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.TrafficManagementSystem
{
    public interface ITrafficManager
    {
        void AddToQueue(int vehicleId);
        void MoveToRoundabout();
        void ExitRoundabout(int vehicleId);
        void ShowState();
    }
}
