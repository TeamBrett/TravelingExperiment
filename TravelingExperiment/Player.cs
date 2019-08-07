using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class Player : Entity
    {
        public int ID { get; set; }
        public override string Name {get; set;}
        public string JumpGateLocation { get; set; }
        public string SpacePortLocation { get; set; }
        public string InstanceLocation { get; set; }
        public int InSolarSystem { get; set; }


    }
}
