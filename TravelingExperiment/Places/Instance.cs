using System;

using CelestialTravels0_1.GameContexts;

namespace CelestialTravels0_1.Places
{
    public class Instance : Place
    {
        public string InSpacePort { get; set; }

        public void Instance1(GameContext gameContext)
        {
            // PlayerMaker part of the game
            gameContext.PlayerMaker.CreatePlayer(gameContext);

            // This is the meet and potatos of the instance(battles and rewards and shit)
            // need to fix the formating of all this text.
            Console.WriteLine("After a childhood of loving protection, and peace, an evil race of Space Sharks have/n shown up at your home planet of" +
                "Fae.  In their invasion they have decapitated your parents, disembowled your siblings, and stolen everything you ever had.  You are" +
                "left to torment, and starvation in a blood bath.");

            StandardMessages.ReturnToContinue();

            Console.WriteLine("After the carnage, a pilot shows up to find you.  He shepards you onto his spaceship " +
                "and flies you to the Capital, Brettopia, where you are presented to the Space King of Knowledge.");

            StandardMessages.ReturnToContinue();

            Console.WriteLine($"SPACE KING BRETT: Young {gameContext.Player.Name} I have heard the tale of your strife at the hand of " +
                "the Space Sharks.  I weep for your misfortune.  I would avenge your family for you, but our vast " +
                "library, The Great Database, does not have the knowledge needed to combat the cruel and ruthless " +
                "Space Sharks.  I task you to become a noble Space Knight of Knowledge, and seek the data we need " +
                "to combat this oppressive enemy.  To help you on your travels, I shall grant you 3 things...First " +
                "I will give you a DiamondDrive in which you will collect as much Data as you can find.  Second I will give " +
                "you a space map of our SolarSytem so you may navigate on your quest for Data.  And finally I shall send " +
                "with you my most trusted advisor... Mr. Piddles.  Go forth, collect the data, and find a way to defeat " +
                "the cruel Space Sharks!\n");

            StandardMessages.ReturnToContinue();

            Console.WriteLine("You gratefully accept your quest, thank the king, and begin to leave with Mr. Piddles.  " +
                "when you are almost to the door the pilot who found you stops you.\n");

            StandardMessages.ReturnToContinue();

            Console.WriteLine($"PILOT:  {gameContext.Player.Name} you will need 3 more things on your journey.  Here take my Blaster to " +
                $"protect yourself and smite your enemies.  You will also need some Credits if you are going to venture " +
                $"across the stars\n");

            Console.WriteLine(@"Hey thanks for the Cash and Gun man!");

            // Weapon Made/Received
            gameContext.WeaponMaker.CreateWeaponBlaster(gameContext);

            if (gameContext.Player.Credits < 100)
            {
                gameContext.Player.Credits += 100;
            }

            Console.WriteLine($"{gameContext.Player.Name} has {gameContext.Player.Credits} Credits\n");
            StandardMessages.ReturnToContinue();

            Console.WriteLine($"{gameContext.Player.Name.ToUpper()}: Come on Mr. Piddles, Let's go Shark hunting!");
            StandardMessages.ReturnToContinue();

            Console.WriteLine("MR. PIDDLES: Meow meow meow, meow meow meow meow!\n");
            StandardMessages.ReturnToContinue();

            gameContext.Fight.DoFight(gameContext);


            // DELETE THIS LATER
            gameContext.Player.XP += 100;  // DELETE THIS LATER
            // DELETE THIS LATER



            // This is where you travel out of the instance back to the planet
            gameContext.Player.SpacePortLocation = "sp1";
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance2(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 2");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance10(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 10");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance11(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 11");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance20(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 20");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance21(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 21");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance30(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 30");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance31(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 31");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance40(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 40");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance41(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 41");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance50(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 50");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance51(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 51");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance60(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 60");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance61(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 61");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance70(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 70");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance71(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 71");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance80(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 80");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }

        public void Instance81(GameContext gameContext)
        {
            // This is the meet and potatos of the instance(battles and rewards and shit)
            Console.WriteLine("you are in instance 81");
            StandardMessages.ReturnToContinue();

            // This is where you travel out of the instance back to the planet
            gameContext.Travel.ReturnToSpacePortFromInstance(gameContext);
        }
    }
}
