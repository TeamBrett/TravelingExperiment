﻿using System;

using CelestialTravels0_1.GameContexts;


namespace CelestialTravels0_1.Places
{
    public class JumpGate : Place
    {


        public void JumpGateOptions(GameContext gameContext)
        {
            int playerSelection;

            Console.WriteLine("You are in " + gameContext.Player.JumpGateLocation);
            Console.WriteLine("0) Travel to SpacePort in solar system (Not yet implimented)");
            Console.WriteLine("1) Travel to nearby JumpGate (Not yet implimented)");
            Console.WriteLine();
            Console.WriteLine("Please enter your selection");

            int userInput;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    if (userInput >= 0 && userInput < 2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between zero and " + (1));
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
                    // TravelToSpacePorts method here (this line will be the caller)
                    gameContext.Travel.TravelToSpacePort(gameContext);
                    Console.WriteLine("Travel to SpacePort (not really)");
                    break;
                case 1:
                    // TravelToJumpGate method here
                    gameContext.Travel.TravelToJumpGateFromJumpGate(gameContext);
                    Console.WriteLine("Travel to JumpGate (not really)");
                    break;
            }
        }
    }
}
