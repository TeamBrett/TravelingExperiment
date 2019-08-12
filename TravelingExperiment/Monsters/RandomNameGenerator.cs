using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

using CelestialTravels0_1.GameContexts;


namespace CelestialTravels0_1.Monsters
{
    public class RandomNameGenerator
    {
        public string RandomNameGen(GameContext gameContext)
        {
            string randomNames = File.ReadAllText(@"C:\Users\jflem\source\repos\TravelingExperiment\TravelingExperiment\GunNames.txt", Encoding.UTF8);
            List<string> GunNames = randomNames.Split(',').ToList<string>();

            var randomGunName = GunNames[gameContext.Roller.GetRandomNumber(0, GunNames.Count)];
            return randomGunName;
        }

        
    }
}
