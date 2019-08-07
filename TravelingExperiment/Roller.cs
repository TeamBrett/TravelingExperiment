using System;
using System.Collections.Generic;
using System.Text;

namespace TravelingExperiment
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
