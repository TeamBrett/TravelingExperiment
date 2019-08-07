using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1
{
    public class WeaponMaker
    {
        string temporaryWeaponNameVariable;

        public void CreateWeaponBlaster(GameContext gameContext)
        {
            var blaster = new Weapon();
            blaster.Type = "Blaster";
            blaster.Name = NameWeapon();
            blaster.Attack = 10;
            blaster.Durability = 100;
            blaster.Equiped = false;

            gameContext.PlayerInventory.WeaponList.Add(blaster);
        }

        public void CreateWeaponDoubleBlaster(GameContext gameContext)
        {
            var doubleBlaster = new Weapon();
            doubleBlaster.Type = "Double Blaster";
            doubleBlaster.Name = NameWeapon();
            doubleBlaster.Attack = 20;
            doubleBlaster.Durability = 75;
            doubleBlaster.Equiped = false;

            gameContext.PlayerInventory.WeaponList.Add(doubleBlaster);
        }

        public void CreateWeaponPhotonSword(GameContext gameContext)
        {
            var photonSword = new Weapon();
            photonSword.Type = "PhotonSword";
            photonSword.Name = NameWeapon();
            photonSword.Attack = 30;
            photonSword.Durability = 50;
            photonSword.Equiped = false;

            gameContext.PlayerInventory.WeaponList.Add(photonSword);
        }

        public string NameWeapon()
        {

            Console.WriteLine("Please name your new weapon");
            temporaryWeaponNameVariable = Console.ReadLine();
            Console.WriteLine("\n");
            return temporaryWeaponNameVariable;
        }
    }
}
