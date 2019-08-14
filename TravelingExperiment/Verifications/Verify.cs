using System;

using CelestialTravels0_1.GameContexts;
using CelestialTravels0_1.UserInterface;

namespace CelestialTravels0_1.Verifications
{
    // bf: a common name for a class like this is "Validator".
    public class Verify
    {
        private readonly IInputOutput io;

        public Verify(IInputOutput userInterface)
        {
            this.io = userInterface;
        }

        internal Verify()
        {
            this.io = new ConsoleInputOutput();
        }

        public bool StringIsNotNull(string input)
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

        public bool HasEnoughMoneyToPurchase(GameContext gameContext, int price)
        {
            if (price <= gameContext.Player.Credits)
            {
                gameContext.Player.Credits -= price;
                return true;
            }
            else
            {
                this.io.WriteLine("You cannot afford this");
                return false;
            }
        }
    }
}
