using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1
{
    public class Character : Entity
    {
        public override string Name { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Job { get; set; }
        public int Credits { get; set; }
        public double Experience { get; set; }
        public double HitPointsCurrent { get; set; } = 100;
        public double HitPointsTotal { get; set; } = 100;
        public double EnergyTotal { get; set; }
        public double EnergyCurrent { get; set; }
        public double WeaponSkill { get; set; } = 1;
        public double ArmorSkill { get; set; }
        public double NavigationSkill { get; set; }
        public double TimeSkill { get; set; }
        public double WeaponDamageCurrent { get; set; }
        public double Roll { get; set; }
        public double Attack { get; set; }
        public int Level { get; set; }

        // Consumables

        public int HealthKitSmallCount { get; set; }
        public int HealthKitLargeCount { get; set; }
        public int HealthKitTotalCount { get; set; }
        public int EnergyKitSmallCount { get; set; }
        public int EnergyKitLargeCount { get; set; }
        public int EnergyKitTotalCount { get; set; }
        public int SmokeGrenadeCount { get; set; }

    }
}
