using System;
using System.Collections.Generic;

using CelestialTravels0_1.Places;


namespace CelestialTravels0_1.GameContexts
{
    public class Lists
    {
        public List<JumpGate> listJumpGate { get; set; } = new List<JumpGate>();
        public List<SpacePort> listSpacePort { get; set; } = new List<SpacePort>();
        public List<Instance> listInstance { get; set; } = new List<Instance>();

    }
}
