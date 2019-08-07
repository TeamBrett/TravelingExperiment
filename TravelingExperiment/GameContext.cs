using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class GameContext
    {
        
        public Lists List { get; set; }
        public JumpGate JumpGate { get; set; }
        public SpacePort SpacePort { get; set; }
        public Instance Instance { get; set; }
        public Player Player { get; set; }
        public Travel Travel { get; set; }

        
    }
}
