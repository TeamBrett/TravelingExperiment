using System;

using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.UserInterface;

namespace CelestialTravels0_1.Places
{
    public class SpacePort : Place
    {
        public void SpacePortOptions(GameContext gameContext)
        {
            int playerSelection;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("You are in " + gameContext.Player.SpacePortLocation);
            Console.WriteLine("0) Save Game");
            Console.WriteLine("1) Load Game");
            Console.WriteLine("2) Quit Game");
            Console.WriteLine("3) Go To Store (Not yet implimented)");
            Console.WriteLine("4) Repair/Heal");
            Console.WriteLine("5) Travel to instance on current planet");
            Console.WriteLine("6) Travel to SpacePort in solar system");
            Console.WriteLine("7) Travel to JumpGate in solar system");
            Console.WriteLine("8) Print Player Stats");
            Console.WriteLine();
            Console.WriteLine("Please enter your selection");
            var tempUserInput = Console.ReadLine();
            playerSelection = new InteractionService().GetUserInputForNumberedOptionMenu(tempUserInput, 9);

            switch (playerSelection)
            {
                case 0:
                    // save game method here
                    gameContext.SaveGame.Save(gameContext);
                    gameContext.SpacePort.SpacePortOptions(gameContext);
                    break;
                case 1:
                    // Load Game method here
                    gameContext.LoadGame.Load(gameContext);
                    gameContext.SpacePort.SpacePortOptions(gameContext);
                    break;
                case 2:
                    // quit game method here
                    Environment.Exit(0);
                    break;
                case 3:
                    // open store method here
                    gameContext.Store.StoreOptions(gameContext);

                    break;
                case 4:
                    // repair method here
                    gameContext.RepairShop.Repair(gameContext);
                    break;
                case 5:
                    // TravelToInstance method here
                    gameContext.Travel.TravelToInstance(gameContext);
                    break;
                
                case 6:
                    // TravelToSpacePorts method here 
                    gameContext.Travel.TravelToSpacePort(gameContext);
                    break;
                case 7:
                    // TravelToJumpGate method here
                    gameContext.Travel.TravelToJumpGateFromSpacePort(gameContext);
                    break;
                case 8:
                    // Print Player Stats
                    gameContext.PlayerStats.PrintPlayerStats(gameContext);
                    gameContext.SpacePort.SpacePortOptions(gameContext);
                    break;
            }
        }
    }
}
