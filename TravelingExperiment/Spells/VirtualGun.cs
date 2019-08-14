using System;
using System.Collections.Generic;
using System.Text;

using CelestialTravels0_1.Bases;
using CelestialTravels0_1.Consumables;
using CelestialTravels0_1.Consumables.EnergyKits;
using CelestialTravels0_1.Consumables.HealthKits;
using CelestialTravels0_1.Fights;
using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.Monsters;
using CelestialTravels0_1.Persistence;
using CelestialTravels0_1.Places;
using CelestialTravels0_1.Players;
using CelestialTravels0_1.Travels;
using CelestialTravels0_1.UserInterface;
using CelestialTravels0_1.Verifications;
using CelestialTravels0_1.Weapons;

namespace CelestialTravels0_1.Spells
{
    public class VirtualGun : Spell
    {
        public void Use(GameContext gameContext)
        {
            Console.WriteLine("How much Energy would you like to use?");
            Console.WriteLine($"You have {gameContext.Player.EnergyCurrent}/{gameContext.Player.EnergyTotal} energy");

            var tempUserInput = Console.ReadLine();

            var playerSelection = new InteractionService().GetUserInputForNumberedOptionMenu(tempUserInput, (int)gameContext.Player.EnergyCurrent);

            gameContext.Player.EnergyTotal -= playerSelection;

            var damage = playerSelection;
        }
    }
}
