using System;

using CelestialTravels0_1.GameContexts;



namespace CelestialTravels0_1.Verifications
{
    public static class Verify
    {
        public static bool StringIsNotNull(string input)
        {
            if (input.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int UserInputForNumberedOptionMenu(int max)
        {
            int playerSelection;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int playerInput))
                {
                    if (playerInput >= 0 && playerInput < max)
                    {
                        playerSelection = playerInput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between 0 and " + (max - 1));
                    }
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
            }
            return playerSelection;
        }

        public static bool HasEnoughMoneyToPurchase(GameContext gameContext, int price)
        {
            if (price <= gameContext.Player.Credits)
            {
                gameContext.Player.Credits -= price;
                return true;
            }
            else
            {
                Console.WriteLine("You cannot afford this");
                return false;
            }
        }
    }
}
