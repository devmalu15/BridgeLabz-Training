using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.CinemaTime
{
    public class Movie
    {
        public String title { get; set; }
        public int durationMins;

        public Movie(string title, int durationMins)
        {
            this.title = title;
            this.durationMins = durationMins;
        }
    }
}
