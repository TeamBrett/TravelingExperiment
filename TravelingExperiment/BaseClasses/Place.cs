using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1
{
    public class Place : Entity
    {
        public int ID { get; set; }
        public override string Name { get; set; }
        public int InSolarSystem { get; set; }

    }
}
