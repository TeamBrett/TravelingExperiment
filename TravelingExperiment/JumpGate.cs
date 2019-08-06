using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
{
    public class JumpGate : Place
    {


        public void JumpGateOptions(Player player, Lists list, Travel travel, SpacePort spacePort, JumpGate jumpGate)
        {
            string playerSelection;

            Console.WriteLine("You are in " + player.JumpGateLocation);
            Console.WriteLine("0) Travel to SpacePort in solar system (Not yet implimented)");
            Console.WriteLine("1) Travel to nearby JumpGate (Not yet implimented)");
            Console.WriteLine();
            Console.WriteLine("Please enter your selection");

            playerSelection = Console.ReadLine();

            switch (playerSelection)
            {
                case "0":
                    // TravelToSpacePorts method here (this line will be the caller)
                    travel.TravelToSpacePort(player, list, travel, spacePort, jumpGate);
                    Console.WriteLine("Travel to SpacePort (not really)");
                    break;
                case "1":
                    // TravelToJumpGate method here
                    travel.TravelToJumpGateFromJumpGate(player, list, travel, spacePort, jumpGate);
                    Console.WriteLine("Travel to JumpGate (not really)");
                    break;
            }
        }
    }
}
