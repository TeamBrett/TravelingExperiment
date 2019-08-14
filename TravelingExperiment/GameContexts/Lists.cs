using System;
using System.Collections.Generic;
using CelestialTravels0_1.Bases;
using CelestialTravels0_1.Places;
using CelestialTravels0_1.Spells;
using CelestialTravels0_1.Weapons;

namespace CelestialTravels0_1.GameContexts
{
    public class Lists
    {
        // Lists for traveling
        public List<JumpGate> listJumpGate { get; set; } = new List<JumpGate>();

        public List<SpacePort> listSpacePort { get; set; } = new List<SpacePort>();

        public List<Instance> listInstance { get; set; } = new List<Instance>();

        // Lists for PlayerMaker
        public List<string> GenderList { get; set; } = new List<string> { "Male", "Female", "NonBinary" };

        public List<string> RaceList { get; set; } = new List<string> { "Lizarian", "Cepholarian", "Fuzzarian" };

        public List<string> JobList { get; set; } = new List<string> { "Navigator", "Gunslinger", "Timebender" };

        // Weapons Lists
        public List<Weapon> WeaponList { get; set; } = new List<Weapon>();

        public List<Spell> SpellList { get; set; } = new List<Spell>();
    }
}
