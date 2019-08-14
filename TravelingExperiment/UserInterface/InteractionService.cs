using System;
using System.Collections.Generic;
using System.Text;
using CelestialTravels0_1.GameContexts;

namespace CelestialTravels0_1.UserInterface
{
    public class InteractionService
    {
        private readonly IInputOutput io;

        public InteractionService(IInputOutput userInterface)
        {
            this.io = userInterface;
        }

        internal InteractionService()
        {
            this.io = new ConsoleInputOutput();
        }

        public int GetUserInputForNumberedOptionMenu(string tempUserInput, int max)
        {
            bool IsValidInput(int input)
            {
                return input >= 0 && input < max;
            }

            var errorMessage = "please enter an integer between 0 and " + (max - 1);

            return this.GetUserInputForNumberedOptionMenu(tempUserInput, IsValidInput, errorMessage);
        }

        public int GetUserInputForNumberedOptionMenu(string tempUserInput, Func<int, bool> isValidInput, string invalidInputMessage)
        {
            // bf: you should consider just reading the user input here rather than pass it in.  I think every place i see this method used
            //     there is a Console.ReadLine() right before it.
            int playerSelection;
            while (true)
            {
                if (int.TryParse(tempUserInput, out int playerInput))
                {
                    if (isValidInput(playerInput))
                    {
                        playerSelection = playerInput;
                        break;
                    }
                    else
                    {
                        this.io.WriteLine(invalidInputMessage);
                    }
                }
                else
                {
                    this.io.WriteLine("Input is not valid, try entering an integer");
                }
            }

            return playerSelection;
        }

        public int GetUserInputForNumberedOptionMenuWithExit(GameContext gameContext, string tempUserInput, int max)
        {
            if (tempUserInput == "exit")
            {
                gameContext.SpacePort.SpacePortOptions(gameContext);
                return -1;
            }
            else
            {
                var playerSelection = this.GetUserInputForNumberedOptionMenu(tempUserInput, 3);
                return playerSelection;
            }
        }
    }
}
