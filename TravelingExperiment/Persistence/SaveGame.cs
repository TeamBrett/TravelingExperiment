using System;
using System.IO;

using CelestialTravels0_1.GameContexts;

using Newtonsoft.Json;

namespace CelestialTravels0_1.Persistence
{
    public class SaveGame
    {
        public void Save(GameContext gameContext)
        {
            // bf: I got an error here because this is not a folder on my computer.
            // todo: add some logic to validate that the directories exist, if they don't then create them.  consider using some of the default locations: https://www.computerhope.com/issues/ch000088.htm
            //       I think maybe just directly putting %APPDATA% into the string here might work?  idk...
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

                // the idea is to catch exceptions you can deal with and then let exceptions you can't deal with bubble up to someone who can.
                // often a program will have a very high level catch everything exception that knows how to exit gracefully and dump diagnostic data.
                // that being said, more often than not you're going to see just standard old "Exception" being caught.
                catch (FileNotFoundException)
                {
                    Console.WriteLine("hmmm, I couldn't find that file, mabye it fell into a black hole?");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong, try again");
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
