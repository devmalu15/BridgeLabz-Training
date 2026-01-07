using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.BirdSantaury
{
    public class Penguin : Bird, ISwimmable
    {
        private String birdName { get; set; }

        public Penguin(String birdName, String tagId, String specieName, String gender) : base(tagId, specieName, gender)
        {
            this.birdName = birdName;
        }

        public override void Track()
        {
            Console.WriteLine("tracking...");
        }

        public void Swim()
        {
            Console.WriteLine("It can swim!");
        }

    }
}
