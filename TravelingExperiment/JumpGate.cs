﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class JumpGate : Place
    {


        public void JumpGateOptions(Player player, Lists list, Travel travel, SpacePort spacePort, JumpGate jumpGate)
        {
            int playerSelection;

            Console.WriteLine("You are in " + player.JumpGateLocation);
            Console.WriteLine("0) Travel to SpacePort in solar system (Not yet implimented)");
            Console.WriteLine("1) Travel to nearby JumpGate (Not yet implimented)");
            Console.WriteLine();
            Console.WriteLine("Please enter your selection");

            int userInput;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
                //travelTo = Convert.ToInt32(Console.ReadLine());
                if (userInput > 0 && userInput < 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("please enter an integer between zero and " + (1));
                }
            }

            playerSelection = userInput;

            switch (playerSelection)
            {
                case 0:
                    // TravelToSpacePorts method here (this line will be the caller)
                    travel.TravelToSpacePort(player, list, travel, spacePort, jumpGate);
                    Console.WriteLine("Travel to SpacePort (not really)");
                    break;
                case 1:
                    // TravelToJumpGate method here
                    travel.TravelToJumpGateFromJumpGate(player, list, travel, spacePort, jumpGate);
                    Console.WriteLine("Travel to JumpGate (not really)");
                    break;
            }
        }
    }
}
