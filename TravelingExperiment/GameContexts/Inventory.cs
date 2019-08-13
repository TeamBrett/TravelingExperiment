using System;
using System.Collections.Generic;

using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.Weapons;


namespace CelestialTravels0_1.GameContexts
{
    public class Inventory
    {
        

        public void EunumerateWeapons(GameContext gameContext)
        {
            foreach (Weapon weapon in gameContext.List.WeaponList)
            {
                Console.WriteLine((gameContext.List.WeaponList.IndexOf(weapon) + ")  " + (weapon.Type) + " " + (weapon.Name) + " Atk =" + (weapon.Attack) + "  Durability =" + (weapon.DurabilityCurrent) +"/" + (weapon.DurabilityMax)));
            }
        }
    }
}
