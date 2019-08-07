﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class FightContext
    {
        // Mechanics Properties
        public Roller Roller { get; set; }
        //Factory Properties
        public MonsterMaker MonsterMaker { get; set; }
        public WeaponMaker WeaponMaker { get; set; }
        // Monster Properties
        public Monster WhiteMonster01  { get; set; }
        public Monster WhiteMonster02  { get; set; }
        public Monster WhiteMonster03  { get; set; }
        public Monster GreenMonster01  { get; set; }
        public Monster GreenMonster02  { get; set; }
        public Monster GreenMonster03  { get; set; }
        public Monster RedMonster01    { get; set; }
        public Monster RedMonster02    { get; set; }
        public Monster RedMonster03    { get; set; }


    }
}