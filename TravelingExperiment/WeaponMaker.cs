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
            blaster.Name = NameWeapon(gameContext);
            blaster.Attack = gameContext.Player.Level * 10;
            blaster.DurabilityMax = 100;
            blaster.DurabilityCurrent = 100;
            blaster.Equiped = false;
            blaster.Price = gameContext.Player.Level * 150;

            gameContext.PlayerInventory.WeaponList.Add(blaster);
        }

        public void CreateWeaponDoubleBlaster(GameContext gameContext)
        {
            var doubleBlaster = new Weapon();
            doubleBlaster.Type = "Double Blaster";
            doubleBlaster.Name = NameWeapon(gameContext);
            doubleBlaster.Attack = gameContext.Player.Level * 200;
            doubleBlaster.DurabilityMax = 75;
            doubleBlaster.DurabilityCurrent = 75;
            doubleBlaster.Equiped = false;
            doubleBlaster.Price = gameContext.Player.Level * 30;

            gameContext.PlayerInventory.WeaponList.Add(doubleBlaster);
        }

        public void CreateWeaponPhotonSword(GameContext gameContext)
        {
            var photonSword = new Weapon();
            photonSword.Type = "PhotonSword";
            photonSword.Name = NameWeapon(gameContext);
            photonSword.Attack = gameContext.Player.Level * 30;
            photonSword.DurabilityMax = 50;
            photonSword.DurabilityCurrent = 50;
            photonSword.Equiped = false;
            photonSword.Price = gameContext.Player.Level * 450;

            gameContext.PlayerInventory.WeaponList.Add(photonSword);
        }

        public string NameWeapon(GameContext gameContext)
        {
            Console.WriteLine("\n");
            Console.WriteLine(@"Please name your new weapon. Enter ""random"" to get a random name ");
            temporaryWeaponNameVariable = Console.ReadLine();

            if (temporaryWeaponNameVariable == "random")
            {
                temporaryWeaponNameVariable = gameContext.RandomNameGenerator.RandomNameGen(gameContext);
            }
            
            Console.WriteLine("\n");
            Console.WriteLine("Your new weapon's name is " + temporaryWeaponNameVariable);
            Console.WriteLine("\n");
            return temporaryWeaponNameVariable;
        }
    }
}
