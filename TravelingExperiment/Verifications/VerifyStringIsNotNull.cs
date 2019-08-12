using System;


namespace CelestialTravels0_1.Verifications
{
    public static class VerifyStringIsNotNull
    {
        public static bool StringIsNotNull(string input)
        {
            if(input.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
