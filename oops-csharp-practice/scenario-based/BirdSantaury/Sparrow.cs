using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.BirdSantaury
{
    public class Sparrow : Bird, IFlyable

    {
        private String birdName { get; set; }

        public Sparrow(String birdName, String tagId, String specieName, String gender) : base(tagId, specieName, gender)
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
