using System;

using CelestialTravels0_1.Bases;

namespace CelestialTravels0_1.Places
{
    public class Place : Entity
    {
        public int ID { get; set; }

        public override string Name { get; set; }

        public int InSolarSystem { get; set; }
    }
}
