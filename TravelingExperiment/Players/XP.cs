using CelestialTravels0_1.GameContexts;
using System;
using System.Collections.Generic;
using System.Text;



namespace CelestialTravels0_1.Players
{
    public class XP
    {
        public void Add(GameContext gameContext, int xpToAdd)
        {
            gameContext.Player.XP += xpToAdd;

            if(gameContext.Player.XP >= gameContext.Player.XpNeededForLevelUp)
            {
                gameContext.Player.XpNeededForLevelUp += gameContext.Player.XpNeededForLevelUp;
                gameContext.Player.Level += 1;

                // Modify all necissary player stats here


                // Spells added by level here

                CheckForNewSpells(gameContext);

            }
        }

        public void CheckForNewSpells(GameContext gameContext)
        {
            if(gameContext.Player.Level == 2)
            {
                switch(gameContext.Player.Job)
                {
                    case "Timebender":
                        {
                            break;
                        }
                    case "Navigator":
                        {
                            break;
                        }
                    case "Gunslinger":
                        {
                            gameContext.List.SpellList.Add(gameContext.VirtualGun);
                            Console.WriteLine("You received a new spell... Virtual Gun!");
                            break;
                        }
                }
            }
        }
    }
}
