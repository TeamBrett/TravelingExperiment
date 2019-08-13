﻿using System;

using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.Verifications;



namespace CelestialTravels0_1.Players
{
    public class PlayerMaker
    {
        public void CreatePlayer(GameContext gameContext)
        {
            gameContext.Player.Name = GetPlayerName();

            
            // Gender selection
            var menuMax = MenuOptions.ListOptions(gameContext.List.GenderList);

            Console.WriteLine($"\nWhat is your gender? ");

            var enteredGender = Verify.UserInputForNumberedOptionMenu(menuMax);


            if (enteredGender == 0)
            {
                gameContext.Player.Gender = "Male";
                Console.WriteLine($"\n{ gameContext.Player.Name} is {gameContext.Player.Gender}\n");
            }

            else if (enteredGender == 1)
            {
                gameContext.Player.Gender = "Female";
                Console.WriteLine($"\n{ gameContext.Player.Name} is {gameContext.Player.Gender}\n");
            }

            else if (enteredGender == 2)
            {
                gameContext.Player.Gender = "NonBinary";
                Console.WriteLine($"\n{ gameContext.Player.Name} is {gameContext.Player.Gender}\n");
            }

            // Race Selection

            Console.WriteLine("\nWhat is your race?");

            var enteredRace = Verify.UserInputForNumberedOptionMenu(menuMax);

            if (enteredRace == 0)
            {
                gameContext.Player.Race = "Lizarian";
                Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race}\n");
            }

            else if (enteredRace == 1)
            {
                gameContext.Player.Race = "Cepholarian";
                Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race}\n");
            }

            else if (enteredRace == 2)
            {
                gameContext.Player.Race = "Fuzzarian";
                Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race}\n");
            }

            // Job Selection

            menuMax = MenuOptions.ListOptions(gameContext.List.RaceList);

            Console.WriteLine("\nWhat is your job?");

            var enteredJob = Verify.UserInputForNumberedOptionMenu(menuMax);

            if (enteredJob == 0)
            {
                gameContext.Player.Job = "Navigator";
                Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race} {gameContext.Player.Job}\n");
                gameContext.Player.NavigationSkill += 5;
                if (gameContext.Player.Race == "Lizarian")
                {
                    Console.WriteLine($"{gameContext.Player.Name} the Navi >*^,^,^~~~");
                }
                Console.WriteLine("NavigationSkill +5\n");
                gameContext.PlayerStats.PrintPlayerStats(gameContext);
                Console.WriteLine("Return any key to continue...");
                Console.ReadLine();
            }

            else if (enteredJob == 1)
            {
                gameContext.Player.Job = "Gunslinger";
                Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race} {gameContext.Player.Job}\n");
                gameContext.Player.WeaponSkill += 5;
                Console.WriteLine("WeaponSkill +5\n");
                gameContext.PlayerStats.PrintPlayerStats(gameContext);
                Console.WriteLine("Return any key to continue...");
                Console.ReadLine();

            }

            else if (enteredJob == 2)
            {
                gameContext.Player.Job = "Timebender";
                Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race} {gameContext.Player.Job}\n");
                gameContext.Player.TimeSkill += 5;
                Console.WriteLine("TimeSkill +5\n");
                gameContext.PlayerStats.PrintPlayerStats(gameContext);
                Console.WriteLine("Return any key to continue...");
                Console.ReadLine();
            }
        }

        public string GetPlayerName()
        {
            string name;
            while (true)
            {
                Console.WriteLine("Hello Hero...What is your name?");
                name = Console.ReadLine();

                // Verification here
                if (Verify.StringIsNotNull(name))
                {
                    Console.WriteLine($"Hello { name} \n");
                    break;
                }
                else
                {
                    Console.WriteLine("You must enter a valid name");
                }
            }

            return name;
        }

    }
}