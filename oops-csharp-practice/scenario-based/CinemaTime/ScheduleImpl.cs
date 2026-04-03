using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.CinemaTime
{
    public class ScheduleImpl : ISchedulable
    {
        public string[,] DisplaySchedule(MovieSchedule movieSchedule)
        {
            return movieSchedule.schedule;
        }

        public void ScheduleMovie(Movie movie, MovieSchedule movieSchedule, int showTime)
        {
            int morningShow = 0;
            int afternoonShow = 1;
            int eveningShow = 2;
            int nightShow = 3;

            int maxDuration = 180;
            if(movie.durationMins < maxDuration)
            {
                if (movieSchedule.schedule[showTime, 1] == "---")
                {
                    movieSchedule.schedule[showTime, 1] = movie.title;
                }
                else
                {
                    Console.WriteLine("Slot is full!");
                }
            }
        }

        public string SearchMovie(String movieSearch, MovieSchedule movieSchedule)
        {
            int shows = 4;
            for(int i = 0; i < shows; i++)
            {
                if(movieSearch == movieSchedule.schedule[i, 1])
                {
                    return movieSchedule.schedule[i, 1] + movieSchedule.schedule[i, 0];
                }
            }
            return null;
        }
    }
}
