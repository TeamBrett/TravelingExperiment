using System;
using CelestialTravels0_1.UserInterface;

namespace CelestialTravels0_1
{
    internal class ConsoleInputOutput : IInputOutput
    {
        public string GetStringInput()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
