using System;

using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.UserInterface;
using CelestialTravels0_1.Verifications;

namespace CelestialTravels0_1.Players
{
    public class PlayerMaker
    {
        public void CreatePlayer(GameContext gameContext)
        {
            gameContext.Player.Name = this.GetPlayerName();

            // Gender selection
            var menuMax = MenuOptions.ListOptions(gameContext.List.GenderList);

            Console.WriteLine($"\nWhat is your gender? ");
            var tempUserInput = Console.ReadLine();

            var enteredGender = new InteractionService().GetUserInputForNumberedOptionMenu(tempUserInput, menuMax);

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
            menuMax = MenuOptions.ListOptions(gameContext.List.RaceList);

            Console.WriteLine("\nWhat is your race?");
            tempUserInput = Console.ReadLine();

            var enteredRace = new InteractionService().GetUserInputForNumberedOptionMenu(tempUserInput, menuMax);

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
            menuMax = MenuOptions.ListOptions(gameContext.List.JobList);

            Console.WriteLine("\nWhat is your job?");
            tempUserInput = Console.ReadLine();

            var enteredJob = new InteractionService().GetUserInputForNumberedOptionMenu(tempUserInput, menuMax);

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
                StandardMessages.ReturnToContinue();
            }
            else if (enteredJob == 1)
            {
                gameContext.Player.Job = "Gunslinger";
                Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race} {gameContext.Player.Job}\n");
                gameContext.Player.WeaponSkill += 5;
                Console.WriteLine("WeaponSkill +5\n");
                gameContext.PlayerStats.PrintPlayerStats(gameContext);
                StandardMessages.ReturnToContinue();
            }
            else if (enteredJob == 2)
            {
                gameContext.Player.Job = "Timebender";
                Console.WriteLine($"\n{ gameContext.Player.Name} is a {gameContext.Player.Gender} {gameContext.Player.Race} {gameContext.Player.Job}\n");
                gameContext.Player.TimeSkill += 5;
                Console.WriteLine("TimeSkill +5\n");
                gameContext.PlayerStats.PrintPlayerStats(gameContext);
                StandardMessages.ReturnToContinue();
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
                if (new Verify().StringIsNotNull(name))
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
