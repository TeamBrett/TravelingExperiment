using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class Player : Character
    {
        public string JumpGateLocation { get; set; }
        public string SpacePortLocation { get; set; }
        public string InstanceLocation { get; set; }
        public int InSolarSystem { get; set; }
        public PlayerStats PlayerStats { get; set; }

        public static class Options
        {
            public static string[] Genders = new string[] { "Male", "Female", "NonBinary" };
            public static string[] Races = new string[] { "Lizarian", "Cepholarian", "Fuzzarian" };
            public static string[] Jobs = new string[] { "Navigator", "Gunslinger", "Timebender" };
        }
    }
}
