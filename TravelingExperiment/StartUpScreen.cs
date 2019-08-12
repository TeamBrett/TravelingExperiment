﻿using System;

using CelestialTravels0_1.GameContexts;


namespace CelestialTravels0_1
{
    public class StartUpScreen
    {
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
            int userInput;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    if (userInput >= 0 && userInput < 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between zero and 2");
                    }
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
            }

            switch(userInput)
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
