using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class Character : Entity
    {
        public override string Name { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Job { get; set; }
        public int Credits { get; set; }
        public double Experience { get; set; }
        public double CurrentHitPoints { get; set; } = 100;
        public double TotalHitPoints { get; set; } = 100;
        public int WeaponSkill { get; set; }
        public int ArmorSkill { get; set; }
        public int NavigationSkill { get; set; }
        public int TimeSkill { get; set; }
        public double CurrentWeaponDamage { get; set; }
        public double Roll { get; set; }
        public double Attack { get; set; }
        public int Level { get; set; }
    }
}
