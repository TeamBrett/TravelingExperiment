using System;
using System.Collections.Generic;

using CelestialTravels0_1.Weapons;


namespace CelestialTravels0_1.GameContexts
{
    public class Inventory
    {
        public List<Weapon> WeaponList = new List<Weapon>();

        public void EunumerateWeapons()
        {
            foreach (Weapon weapon in WeaponList)
            {
                Console.WriteLine((WeaponList.IndexOf(weapon) + ")  " + (weapon.Type) + " " + (weapon.Name) + " Atk =" + (weapon.Attack) + "  Durability =" + (weapon.DurabilityCurrent) +"/" + (weapon.DurabilityMax)));
            }
        }
    }
}
