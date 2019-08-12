using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1.Players
{
    public class GenderOptions
    {
        public List<string> GenderList = new List<string> { "Male", "Female", "NonBinary" };


        public static void ListGenders()
        {
            foreach (string gender in GenderList)
            {
                Console.WriteLine(GenderList.IndexOf(gender) + ") " + gender);
            }
        }
    }
}
