using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1
{
    public class SpacePort : Place
    {

        public void SpacePortOptions(GameContext gameContext)
        {
            int playerSelection;

            Console.WriteLine("You are in " + gameContext.Player.SpacePortLocation);
            Console.WriteLine("0) Save Game");
            Console.WriteLine("1) Load Game");
            Console.WriteLine("2) Quit Game (Not yet impliment)");
            Console.WriteLine("3) Buy Consumable (Not yet implimented)");
            Console.WriteLine("4) Repair (Not yet implimented)");
            Console.WriteLine("5) Travel to instance on current planet");
            Console.WriteLine("6) Travel to SpacePort in solar system");
            Console.WriteLine("7) Travel to JumpGate in solar system");
            Console.WriteLine("8) Print Player Stats");
            Console.WriteLine();
            Console.WriteLine("Please enter your selection");

            int userInput;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    if (userInput > 0 && userInput < 8)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between zero and " + (8));
                    }
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
            }

            playerSelection = userInput;
            switch (playerSelection)
            {
                case 0:
                    // save game method here
                    gameContext.SaveGame.Save(gameContext);
                    Console.WriteLine("Game Saved");
                    gameContext.SpacePort.SpacePortOptions(gameContext);
                    break;
                case 1:
                    gameContext.LoadGame.Load(gameContext);
                    Console.WriteLine("Game Loaded");
                    gameContext.SpacePort.SpacePortOptions(gameContext);
                    break;
                case 2:
                    // quit game method here
                    Console.WriteLine("Game Quit (not really)");
                    break;
                case 3:
                    // open store method here
                    Console.WriteLine("Store Loaded (not really)");
                    break;
                case 4:
                    // repair method here
                    Console.WriteLine("Stuff Repaired (not really)");
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
