using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.CinemaTime
{
    public class MovieSchedule
    {
        public string[,] schedule = new string[4, 2];

        public MovieSchedule()
        {
            
            schedule[0, 0] = "Morning Show (9:00 AM)";
            schedule[1, 0] = "Matinee Show (1:00 PM)";
            schedule[2, 0] = "Evening Show (6:00 PM)";
            schedule[3, 0] = "Night Show   (9:00 PM)";

            
            schedule[0, 1] = "---";
            schedule[1, 1] = "---";
            schedule[2, 1] = "---";
            schedule[3, 1] = "---";
        }

    }
}
