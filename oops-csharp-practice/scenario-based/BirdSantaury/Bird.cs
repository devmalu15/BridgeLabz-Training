using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.ScenarioBased.BirdSantaury
{
    public abstract class Bird
    {
        private String tagId { get; set; }
        private String specieName { get; set; }
        private String gender { get; set; }

        public Bird(string tagId, string specieName, string gender)
        {
            this.tagId = tagId;
            this.specieName = specieName;
            this.gender = gender;
        }

        public abstract void Track();




    }
}
