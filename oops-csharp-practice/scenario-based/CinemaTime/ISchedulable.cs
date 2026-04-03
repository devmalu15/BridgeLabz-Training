using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.CinemaTime
{
    public interface ISchedulable
    {
        void ScheduleMovie(Movie movie, MovieSchedule movieSchedule, int showTime);

        String SearchMovie(String movieSearch, MovieSchedule movieSchedule);

        String[,] DisplaySchedule(MovieSchedule movieSchedule);
    }
}
