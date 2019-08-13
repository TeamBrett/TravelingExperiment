using System;
using System.Collections.Generic;
using System.Text;

namespace CelestialTravels0_1.GameContexts
{
    public class MenuOptions
    {
        public static int ListOptions<T> (List<T> list)
        {
            int menuMax = list.Count;
            foreach (T thing in list)
            {
                Console.WriteLine(list.IndexOf(thing) + ") " + thing);
            }
            return menuMax;
        }
    }
}
