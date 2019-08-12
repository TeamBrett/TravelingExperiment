using System;
using System.Collections.Generic;
using CelestialTravels0_1.Bases;


namespace CelestialTravels0_1.Players
{
    public class Player : Character
    {
        public string JumpGateLocation { get; set; }
        public string SpacePortLocation { get; set; }
        public string InstanceLocation { get; set; }
        public int InSolarSystem { get; set; }
        public PlayerStats PlayerStats { get; set; }
        public double BaseAttack { get; set; }

    }
}

