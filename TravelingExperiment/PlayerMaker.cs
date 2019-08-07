using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class PlayerMaker
    {
        public void CreatePlayer(GameContext gameContext)
        {
            var genderValid = false;
            var raceValid = false;
            var jobValid = false;

            Console.WriteLine("Welcome to CelestialTravels...What is your name?");

            gameContext.Player.Name = Console.ReadLine();

            Console.WriteLine($"Hello { gameContext.Player.Name} \n");

            do
            {
                foreach (string gender in Player.Options.Genders)
                {
                    Console.WriteLine(gender);
                }


                Console.WriteLine($"\nWhat is your gender? ");

                var enteredGender = Console.ReadLine();

                if (enteredGender == "Male")
                {
                    gameContext.Player.Gender = "Male";
                    Console.WriteLine($"\n{ gameContext.Player.Name} is {gameContext.Player.Gender}\n");
                    genderValid = true;
                }

                else if (enteredGender == "Female")
                {
                    gameContext.Player.Gender = "Female";
                    Console.WriteLine($"\n{ gameContext.Player.Name} is {gameContext.Player.Gender}\n");
                    genderValid = true;
                }

                else if (enteredGender == "NonBinary")
                {
                    gameContext.Player.Gender = "NonBinary";
                    Console.WriteLine($"\n{ gameContext.Player.Name} is {gameContext.Player.Gender}\n");
                    genderValid = true;
                }
            }
            while (genderValid == false);


            do
            {
                foreach (string race in Player.Options.Races)
                {
                    Console.WriteLine(race);
                }

                Console.WriteLine("\nWhat is your race?");

                var enteredRace = Console.ReadLine();

                if (enteredRace == "Lizarian")
                {
                    gameContext.Player.Race = "Lizarian";
                    Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race}\n");
                    raceValid = true;
                }

                else if (enteredRace == "Cepholarian")
                {
                    gameContext.Player.Race = "Cepholarian";
                    Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race}\n");
                    raceValid = true;
                }

                else if (enteredRace == "Fuzzarian")
                {
                    gameContext.Player.Race = "Fuzzarian";
                    Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race}\n");
                    raceValid = true;
                }
            }
            while (raceValid == false);

            do
            {
                foreach (string job in Player.Options.Jobs)
                {
                    Console.WriteLine(job);
                }

                Console.WriteLine("\nWhat is your job?");

                var enteredJob = Console.ReadLine();

                if (enteredJob == "Navigator")
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
                    jobValid = true;
                }

                else if (enteredJob == "Gunslinger")
                {
                    gameContext.Player.Job = "Gunslinger";
                    Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race} {gameContext.Player.Job}\n");
                    gameContext.Player.WeaponSkill += 5;
                    Console.WriteLine("WeaponSkill +5\n");
                    gameContext.PlayerStats.PrintPlayerStats(gameContext);
                    Console.WriteLine("Return any key to continue...");
                    Console.ReadLine();
                    jobValid = true;

                }

                else if (enteredJob == "Timebender")
                {
                    gameContext.Player.Job = "Timebender";
                    Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race} {gameContext.Player.Job}\n");
                    gameContext.Player.TimeSkill += 5;
                    Console.WriteLine("TimeSkill +5\n");
                    gameContext.PlayerStats.PrintPlayerStats(gameContext);
                    Console.WriteLine("Return any key to continue...");
                    Console.ReadLine();
                    jobValid = true;
                }
            }
            while (jobValid == false);
        }

    }
}
