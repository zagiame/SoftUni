using System;

namespace FootballTeamGenerator
{
    public static class Validator
    {
        public static void ThrowIfEmptyOrWhiteSpace(string item, string message)
        {
            if (string.IsNullOrWhiteSpace(item))
            {
                throw new ArgumentException(message);
            }
        }

        public static void ThrowIfNumberIsNotInRange(int min, int max, int value, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }
    }
}