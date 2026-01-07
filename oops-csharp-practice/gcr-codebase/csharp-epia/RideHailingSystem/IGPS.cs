using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.RideHailingSystem
{
    public interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string location);
    }
}
