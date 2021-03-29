using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class Validator
    {
        public static void ThrowIfNumberIsNotInRange(int min, int max, int number, string exceptionMessage)
        {
            if (number < min || number > max)
            {
                throw new AggregateException(exceptionMessage);
            }
        }

        public static void ThrowIfValueIsNotAllowed(HashSet<string> allowedValues, string value,
            string exceptionMessage)
        {
            if (allowedValues.Contains(value) == false)
            {
                throw new ArgumentException(exceptionMessage);
            }
        }
    }
}
