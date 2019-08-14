using System;

using CelestialTravels0_1.Consumables;

namespace CelestialTravels0_1.Weapons
{
    public class Weapon : Consumable
    {
        public string Type { get; set; }

        public override string Name { get; set; }

        public int Attack { get; set; }

        public bool Equiped { get; set; }

        public int DurabilityMax { get; set; }

        public int DurabilityCurrent { get; set; }
    }
}
