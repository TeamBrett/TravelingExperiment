﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1
{
    public class GameContext
    {

        public Lists List { get; set; }
        public JumpGate JumpGate { get; set; }
        public SpacePort SpacePort { get; set; }
        public Instance Instance { get; set; }
        public Player Player { get; set; }
        public Travel Travel { get; set; }
        public Inventory Inventory { get; set; }
        public Inventory PlayerInventory { get; set; }
        public PlayerAttackCalculator PlayerAttackCalculator { get; set; }
        public PlayerStats PlayerStats { get; set; }
        public WeaponMaker WeaponMaker { get; set; }
        public PlayerMaker PlayerMaker { get; set; }
        public LoadGame LoadGame { get; set; }
        public SaveGame SaveGame { get; set; }
        public RandomNameGenerator RandomNameGenerator { get; set; }
        public RepairShop RepairShop { get; set; }
        public Store Store { get; set; }

        // Consumables
        public HealthKitSmall HealthKitSmall { get; set; }
        public HealthKitLarge HealthKitLarge { get; set; }
        public HealthKitTotal HealthKitTotal { get; set; }
        public EnergyKitSmall EnergyKitSmall { get; set; }
        public EnergyKitLarge EnergyKitLarge { get; set; }
        public EnergyKitTotal EnergyKitTotal { get; set; }
        public SmokeGrenade SmokeGrenade { get; set; }





        // Fighting stuff
        // Mechanics Properties
        public Fight Fight { get; set; }
        public Roller Roller { get; set; }
        //Factory Properties
        public MonsterMaker MonsterMaker { get; set; }
        // Monster Properties
        public Monster WhiteMonster01 { get; set; }
        public Monster WhiteMonster02 { get; set; }
        public Monster WhiteMonster03 { get; set; }
        public Monster GreenMonster01 { get; set; }
        public Monster GreenMonster02 { get; set; }
        public Monster GreenMonster03 { get; set; }
        public Monster RedMonster01 { get; set; }
        public Monster RedMonster02 { get; set; }
        public Monster RedMonster03 { get; set; }


    }
}
