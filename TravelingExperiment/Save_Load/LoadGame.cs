using System;
using System.IO;
using Newtonsoft.Json;

using CelestialTravels0_1.GameContexts;


namespace CelestialTravels0_1.Save_Load
{
    public class LoadGame
    {
        public void Load(GameContext gameContext)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Which game shall we load?");

                    string[] files = Directory.GetFiles(@"c:\CelestialTravels\Save", "*.Json");

                    foreach (string file in files)
                    {
                        Console.WriteLine(file);
                    }
                    Console.WriteLine(@"Enter the name of the file you wish to load (do not include the c:\CelestialTravels\save\)");
                    Console.WriteLine(@"Enter ""exit"" to exit Load Game");

                    var gameToLoad = Console.ReadLine();
                    if(gameToLoad == "exit")
                    {
                        break;
                    }

                    // read file into a string and deserialize JSON to a type
                    GameContext gameContextLoad = JsonConvert.DeserializeObject<GameContext>(File.ReadAllText(@"c:\CelestialTravels\Save\" + gameToLoad + ".json"));
                    gameContext = gameContextLoad;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Something went wrong");
                    Console.WriteLine(ex.ToString());
                }
                Console.WriteLine();
                Console.WriteLine("Game Loaded");
                Console.WriteLine();
                gameContext.PlayerStats.PrintPlayerStats(gameContext);

                gameContext.SpacePort.SpacePortOptions(gameContext);
                break;

            }
        }
    }
}
