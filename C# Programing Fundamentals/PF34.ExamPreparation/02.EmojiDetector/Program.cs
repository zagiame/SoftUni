using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            //validator
            string emojiPattern = @"(:{2}|\*{2})[A-Z][a-z]{2,}\1";
            string numberPattern = @"\d";

            var emojiValidator = new Regex(emojiPattern);
            var numberValidator = new Regex(numberPattern);

            //input
            string input = Console.ReadLine();

            // calculation
            long coolThreshold = 1;
            numberValidator.Matches(input)
                .Select(match => match.Value)
                .Select(int.Parse)
                .ToList()
                .ForEach(item => coolThreshold = coolThreshold * item);


            // EMOJI
            var emoji = emojiValidator.Matches(input);
            var coolEmoji = emojiValidator
                .Matches(input)
                .Select(match => match.Value)
                .Where(emoji => emoji.Substring(2, emoji.Length - 4)
                                     .ToCharArray()
                                     .Sum(x => (int)x) > coolThreshold)
                .ToList();

            //output
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emoji.Count} emojis found in the text. The cool ones are:");

            foreach (var item in coolEmoji)
            {
                Console.WriteLine(item);
            }
        }
    }
}
