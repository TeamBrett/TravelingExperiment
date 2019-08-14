using System;

using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.UserInterface;

namespace CelestialTravels0_1.Places
{
    public class JumpGate : Place
    {
        public void JumpGateOptions(GameContext gameContext)
        {
            Console.WriteLine("You are in " + gameContext.Player.JumpGateLocation);
            Console.WriteLine("0) Travel to SpacePort in solar system (Not yet implimented)");
            Console.WriteLine("1) Travel to nearby JumpGate (Not yet implimented)");
            Console.WriteLine();
            Console.WriteLine("Please enter your selection");

            var tempUserInput = Console.ReadLine();

            var playerSelection = new InteractionService().GetUserInputForNumberedOptionMenu(tempUserInput, 2);

            switch (playerSelection)
            {
                case 0:
                    // TravelToSpacePorts method here (this line will be the caller)
                    gameContext.Travel.TravelToSpacePort(gameContext);
                    break;
                case 1:
                    // TravelToJumpGate method here
                    gameContext.Travel.TravelToJumpGateFromJumpGate(gameContext);
                    break;
            }
        }
    }
}
