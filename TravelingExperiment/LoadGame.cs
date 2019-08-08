using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace CelestialTravels0_1
{
    public class LoadGame
    {
        public void Load(GameContext gameContext)
        {
            Console.WriteLine("Which game shall we load?");

            string[] files = Directory.GetFiles(@"c:\CelestialTravels\Save", "*.Json");

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine(@"Enter the name of the file you wish to load (do not include the c:\CelestialTravels\save\)");

            var gameToLoad = Console.ReadLine();

            // read file into a string and deserialize JSON to a type
            GameContext gameContextLoad = JsonConvert.DeserializeObject<GameContext>(File.ReadAllText(@"c:\CelestialTravels\Save\" + gameToLoad + ".json"));

            gameContext = gameContextLoad;
            gameContext.PlayerStats.PrintPlayerStats(gameContext);

            gameContext.SpacePort.SpacePortOptions(gameContext);
        }

        
    }
}
