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

            // read file into a string and deserialize JSON to a type
            GameContext gameContextLoad = JsonConvert.DeserializeObject<GameContext>(File.ReadAllText(@"c:\CelestialTravels\Save\GameSave.json"));

            gameContext = gameContextLoad;
            gameContext.SpacePort.SpacePortOptions(gameContext);
        }

        
    }
}
