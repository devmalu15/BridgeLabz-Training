using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.BirdSantaury
{
    public class Eagle : Bird, IFlyable

    {
        private String birdName { get; set; }

        public Eagle(String birdName, String tagId, String specieName, String gender) : base(tagId, specieName, gender)
        {
            this.birdName = birdName;
        }

        public override void Track()
        {
            Console.WriteLine("tracking...");
        }

        public void Fly()
        {
            Console.WriteLine("It can Fly!");
        }
    }
}
