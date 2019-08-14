using System;

using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.UserInterface;
using CelestialTravels0_1.Verifications;

namespace CelestialTravels0_1
{
    public class StartUpScreen
    {
        private readonly InteractionService interactionService;

        public StartUpScreen()
        {
            this.interactionService = new InteractionService();
        }

        public void StartUp(GameContext gameContext)
        {
            Console.WriteLine("WELCOME TO CELESTIAL TRAVELS");
            Console.WriteLine();
            Console.WriteLine("Return to continue");
            Console.ReadLine();

            Console.WriteLine("0) Start New Game");
            Console.WriteLine("1) Load Saved Game");
            Console.WriteLine("2) Quit Now... This game sucks already");
            Console.WriteLine();
            Console.WriteLine("Select an option");
            var tempUserInput = Console.ReadLine();

            var playerSelection = this.interactionService.GetUserInputForNumberedOptionMenu(tempUserInput, 3);

            switch (playerSelection)
            {
                case 0:
                    // New game
                    gameContext.Instance.Instance1(gameContext);
                    break;
                case 1:
                    // Load game
                    gameContext.LoadGame.Load(gameContext);
                    gameContext.SpacePort.SpacePortOptions(gameContext);
                    break;
                case 2:
                    // Quit the fucking game
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
