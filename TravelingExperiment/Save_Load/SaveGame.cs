using System;
using System.IO;
using Newtonsoft.Json;

using CelestialTravels0_1.GameContexts;

namespace CelestialTravels0_1.Save_Load
{
    public class SaveGame
    {
        public void Save(GameContext gameContext)
        {
            string[] files = Directory.GetFiles(@"c:\CelestialTravels\Save", "*.Json");

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the name of your Save Game file.  Enter the same name to over write previous game.");
                    Console.WriteLine(@"Do not include the (c:\CelestialTravels\Save\)");
                    var saveGameName = Console.ReadLine();

                    // serialize JSON to a string and then write string to a file
                    File.WriteAllText(@"c:\CelestialTravels\Save\" + saveGameName + ".json", JsonConvert.SerializeObject(gameContext));
                    Console.WriteLine("Game Saved");
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Something went wrong, try again");
                    Console.WriteLine(ex.ToString());
                }
            }
            
        }
    }
}
