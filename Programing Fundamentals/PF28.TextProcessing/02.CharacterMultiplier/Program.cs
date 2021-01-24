using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] input = Console.ReadLine().Split();

            // calculation
            string firstWord = input[0];
            string secondWord = input[1];

            string shortestWord = firstWord;
            string longestWord = secondWord;


            if (firstWord.Length >= secondWord.Length)
            {
                shortestWord = secondWord;
                longestWord = firstWord;
            }

            int sum = 0;

            for (int i = 0; i < shortestWord.Length; i++)
            {
                int multiply = shortestWord[i] * longestWord[i];
                sum = sum + multiply;
            }

            for (int i = shortestWord.Length; i < longestWord.Length; i++)
            {
                sum = sum + longestWord[i];
            }

            // output
            Console.WriteLine(sum);
        }
    }
}
