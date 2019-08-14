using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CelestialTravels0_1.GameContexts
{
    public class RandomNameGenerator
    {
        public string RandomNameGen(GameContext gameContext)
        {
            var assemblyFilePath = Assembly.GetAssembly(typeof(Program)).Location;
            var assemblyDirectory = Path.GetDirectoryName(assemblyFilePath);

            // bf: to make this work, right click GunNames.txt in the solution, select Properties and then set the option to be "Always Copy to Output Directory"
            //     this will make sure the .txt file gets included when the code is compiled and it will be in a known place no matter where the program runs.
            var gunNamesFileName = Path.Combine(assemblyDirectory, "GameContexts", "GunNames.txt");

            // bf: might consider catching a FileNotFoundException here, but we would need to decide what the best way to handle that would be?  maybe just return the word "random"?  Ask user to find the file? idk.
            var randomNames = File.ReadAllText(gunNamesFileName, Encoding.UTF8);

            ////string randomNames = File.ReadAllText(@"C:\Users\jflem\source\repos\TravelingExperiment\TravelingExperiment\GameContexts\GunNames.txt", Encoding.UTF8);
            List<string> GunNames = randomNames.Split(',').ToList<string>();

            var randomGunName = GunNames[gameContext.Roller.GetRandomNumber(0, GunNames.Count)];
            return randomGunName;
        }
    }
}
