using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class SpacePort : Place
    {
        public string InSolarSystem { get; set; }

        public void SpacePortOptions(PlayerCharacter player, Planet planet, Travel travel, SolarSystem solarSystem, SpacePort spacePort, JumpGate jumpGate)
        {
            string playerSelection;

            Console.WriteLine("You are in " + spacePort.Name);
            Console.WriteLine("0) Save Game (Not yet implimented)");
            Console.WriteLine("1) Load Game (Not yet implimented)");
            Console.WriteLine("2) Quit Game (Not yet impliment)");
            Console.WriteLine("3) Buy Consumable (Not yet implimented)");
            Console.WriteLine("4) Repair (Not yet implimented)");
            Console.WriteLine("5) Travel to instance on current planet (Not yet implimented)");
            Console.WriteLine("6) Travel to SpacePort in solar system (Not yet implimented)");
            Console.WriteLine("7) Travel to JumpGate in solar system (Not yet implimented)");
            Console.WriteLine();
            Console.WriteLine("Please enter your selection");

            playerSelection = Console.ReadLine();

            switch (playerSelection)
            {
                case "0":
                    // save game method here
                    Console.WriteLine("Game Saved (not really)");
                    break;
                case "1":
                    // load game method here
                    Console.WriteLine("Game Loaded (not really)");
                    break;
                case "2":
                    // quit game method here
                    Console.WriteLine("Game Quit (not really)");
                    break;
                case "3":
                    // open store method here
                    Console.WriteLine("Store Loaded (not really)");
                    break;
                case "4":
                    // repair method here
                    Console.WriteLine("Stuff Repaired (not really)");
                    break;
                case "5":
                    // TravelToInstance method here
                    Console.WriteLine("Instance01 Loaded (not really)");
                    break;
                case "6":
                    // TravelToInstance method here
                    Console.WriteLine("Instance02 Loaded (not really)");
                    break;
                case "7":
                    // TravelToInstance method here
                    Console.WriteLine("Instance03 Loaded (not really)");
                    break;
                case "8":
                    // TravelToSpacePorts method here (this line will be the caller)

                    travel.TravelToSpacePort(player, spacePort, travel, solarSystem, planet, jumpGate);
                    Console.WriteLine("Travel to JumpGate (not really)");
                    break;
                case "9":
                    // TravelToJumpGate method here
                    travel.TravelToJumpGate(player, solarSystem, jumpGate, planet, travel, spacePort);
                    Console.WriteLine("Travel to JumpGate (not really)");
                    break;
            }

        }
    }
}
