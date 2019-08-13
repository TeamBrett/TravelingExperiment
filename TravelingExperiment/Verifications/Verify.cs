using System;


namespace CelestialTravels0_1.Verifications
{
    public static class Verify
    {
        public static bool StringIsNotNull(string input)
        {
            if(input.Length > 0)
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
                    if (playerInput >= 0 && playerInput <= max)
                    {
                        playerSelection = playerInput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please enter an integer between 0 and " + max);
                    }
                }
                else
                {
                    Console.WriteLine("Input is not valid, try entering an integer");
                }
            }
            return playerSelection;
        }
    }
}
