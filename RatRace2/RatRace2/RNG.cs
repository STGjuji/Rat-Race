using System;

namespace RatRace2
{
    public static class RNG
    {
        private static Random _rng = new Random();
        public static int Range( int lower,int upper)
        {
            return _rng.Next(lower, upper);
        }
    }
}
