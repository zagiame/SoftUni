using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            // calculation
            while (input != "END")
            {
                bool result = IsPalindrome(input);
                Console.WriteLine(result.ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        public static bool IsPalindrome(string input)
        {
            if (input.Length == 1 || input.Length == 0) return true;
            return input[0] == input[input.Length - 1] && IsPalindrome(input.Substring(1, input.Length - 2));
        }
    }
}
