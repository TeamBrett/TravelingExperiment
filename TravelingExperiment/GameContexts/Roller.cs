using System;

namespace CelestialTravels0_1.GameContexts
{
    public class Roller
    {
        private static readonly Random getRandom = new Random();

        public int GetRandomNumber(int min, int max)
        {
            lock (getRandom)
            {
                return getRandom.Next(min, max);
            }
        }
    }
}
