using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.BirdSantaury
{
    public class BirdUtility
    {
        public static void Main(String[] args)
        {
            List<Bird> mySantuary = new List<Bird>
        {
            new Eagle("baaaazzzz", "12bh3v4", "egaliaflyia", "male"),
            new Penguin("pinguen", "12bh3v5", "penguaguenia", "female")
        };

            foreach (var bird in mySantuary)
            {

                bird.Track();


                if (bird is IFlyable flyer)
                {
                    flyer.Fly();
                }
                else if (bird is ISwimmable swimmer)
                {
                    swimmer.Swim();
                }
            }
        }
    }
}
