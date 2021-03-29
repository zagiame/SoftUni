using System;

namespace ShoppingSpree
{
    public class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string text, string exceptionMessage)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException(exceptionMessage);
            }
        }

        public static void ThrowIfNumberIsNegative(decimal number, string exceptionMessage)
        {
            if (number<0)
            {
                throw new ArgumentException(exceptionMessage);
            }
        }
    }
}