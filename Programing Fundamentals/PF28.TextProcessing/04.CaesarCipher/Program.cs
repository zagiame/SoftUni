using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            // output
            foreach (char item in input)
            {
                char current = (char)(item + 3);
                Console.Write(current);
            }
        }
    }
}
