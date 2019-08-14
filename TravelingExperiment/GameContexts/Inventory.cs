using System;
using System.Collections.Generic;

using CelestialTravels0_1.Bases;
using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.Spells;
using CelestialTravels0_1.Weapons;

namespace CelestialTravels0_1.GameContexts
{
    public class Inventory
    {
        public void EunumerateWeapons(GameContext gameContext)
        {
            foreach (Weapon weapon in gameContext.List.WeaponList)
            {
                Console.WriteLine(gameContext.List.WeaponList.IndexOf(weapon) + ")  " + weapon.Type + " " + weapon.Name + " Atk =" + weapon.Attack + "  Durability =" + weapon.DurabilityCurrent +"/" + weapon.DurabilityMax);
            }
        }

        public void EnumerateSpells(GameContext gameContext)
        {
            foreach (Spell spell in gameContext.List.SpellList)
            {
                Console.WriteLine((gameContext.List.SpellList.IndexOf(spell) + ")  " + (spell.Name) + " " + (spell.Description)));
            }
        }
    }
}
