using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace CelestialTravels0_1
{
    public class SaveGame
    {
        public void Save(GameContext gameContext)
        {
            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"c:\CelestialTravels\Save\GameSave.json", JsonConvert.SerializeObject(gameContext));
        }
    }
}
