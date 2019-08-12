using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1.Players
{
    public static class RaceOptions
    {
        public static List<string> RaceList = new List<string> { "Lizarian", "Cepholarian", "Fuzzarian" };

        public static void ListRaces()
        {
            foreach (string race in RaceList)
            {
                Console.WriteLine(RaceList.IndexOf(race) + ") " + race);
            }
        }
    }
}
