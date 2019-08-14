using System;

using CelestialTravels0_1.GameContexts;

namespace CelestialTravels0_1.Weapons
{
    public class WeaponMaker
    {
        private string temporaryWeaponNameVariable;

        public void CreateWeaponBlaster(GameContext gameContext)
        {
            var blaster = new Weapon()
            {
                Type = "Blaster",
                Name = this.NameWeapon(gameContext),
                Attack = gameContext.Player.Level * 10,
                DurabilityMax = 100,
                DurabilityCurrent = 100,
                Equiped = false,
                Price = gameContext.Player.Level * 150,
            };
            gameContext.List.WeaponList.Add(blaster);
        }

        public void CreateWeaponDoubleBlaster(GameContext gameContext)
        {
            var doubleBlaster = new Weapon()
            {
                Type = "Double Blaster",
                Name = this.NameWeapon(gameContext),
                Attack = gameContext.Player.Level * 20,
                DurabilityMax = 75,
                DurabilityCurrent = 75,
                Equiped = false,
                Price = gameContext.Player.Level * 300,
            };

            gameContext.List.WeaponList.Add(doubleBlaster);
        }

        public void CreateWeaponPhotonSword(GameContext gameContext)
        {
            var photonSword = new Weapon()
            {
                Type = "PhotonSword",
                Name = this.NameWeapon(gameContext),
                Attack = gameContext.Player.Level * 30,
                DurabilityMax = 50,
                DurabilityCurrent = 50,
                Equiped = false,
                Price = gameContext.Player.Level * 450,
            };

            gameContext.List.WeaponList.Add(photonSword);
        }

        public string NameWeapon(GameContext gameContext)
        {
            Console.WriteLine("\n");
            Console.WriteLine(@"Please name your new weapon. Enter ""random"" to get a random name ");
            this.temporaryWeaponNameVariable = Console.ReadLine();

            if (this.temporaryWeaponNameVariable == "random")
            {
                this.temporaryWeaponNameVariable = gameContext.RandomNameGenerator.RandomNameGen(gameContext);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Your new weapon's name is " + this.temporaryWeaponNameVariable);
            Console.WriteLine("\n");
            StandardMessages.ReturnToContinue();
            return this.temporaryWeaponNameVariable;
        }
    }
}
