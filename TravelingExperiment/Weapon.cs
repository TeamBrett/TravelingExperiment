using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class Weapon : Entity
    {
        public string Type { get; set; }
        public override string Name { get; set; }
        public int Attack { get; set; }
        public bool Equiped { get; set; }
        public int Durability { get; set; }
    }
}
