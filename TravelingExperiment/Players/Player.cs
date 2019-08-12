using System;

using CelestialTravels0_1.Bases;


namespace CelestialTravels0_1.Players
{
    public class Player : Character
    {
        public string JumpGateLocation { get; set; }
        public string SpacePortLocation { get; set; }
        public string InstanceLocation { get; set; }
        public int InSolarSystem { get; set; }
        public PlayerStats PlayerStats { get; set; }
        public double BaseAttack { get; set; }


        

        public static class GenderOptions
        {
            public static string[] Genders = new string[] { "Male", "Female", "NonBinary" };

            public static void ListGenders()
            {
                foreach (string gender in Player.GenderOptions.Genders)
                {
                    Console.WriteLine(gender);
                }
            }
        }

        public static class RaceOptions
        {
            public static string[] Races = new string[] { "Lizarian", "Cepholarian", "Fuzzarian" };

            public static void ListRaces()
            {
                foreach (string race in Player.RaceOptions.Races)
                {
                    Console.WriteLine(race);
                }
            }
        }

        public static class JobOptions
        {
            public static string[] Jobs = new string[] { "Navigator", "Gunslinger", "Timebender" };
            public static void ListJobs()
            {
                foreach (string job in Player.JobOptions.Jobs)
                {
                    Console.WriteLine(job);
                }
            }
        }
    }
}

