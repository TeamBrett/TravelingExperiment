using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1.Players
{
    public static class JobOptions
    {
        public static List<string> JobList = new List<string> { "Navigator", "Gunslinger", "Timebender" };

        public static void ListJobs()
        {
            foreach (string job in JobList)
            {
                Console.WriteLine(JobList.IndexOf(job) + ") " + job);
            }
        }
    }
}
