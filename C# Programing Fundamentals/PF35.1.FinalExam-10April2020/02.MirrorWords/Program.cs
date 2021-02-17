using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // validation
            string pattern = @"(@|#)(?<first>[A-Za-z]{3,})(\1)(\1)(?<second>[A-Za-z]{3,})(\1)";
            var validator = new Regex(pattern);

            // input
            string text = Console.ReadLine();

            // calculation
            var words = new List<string>();
            var valid = validator.Matches(text);

            if (valid.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }

            else
            {
                Console.WriteLine($"{valid.Count} word pairs found!");

                foreach (Match item in valid)
                {
                    string first = item.Groups["first"].Value;
                    string second = item.Groups["second"].Value;

                    if (first == Reverse(second))
                    {
                        words.Add($"{first} <=> {second}");
                    }

                }
            }

            // output

            if (words.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", words));
            }

            else
            {
                Console.WriteLine("No mirror words!");
            }

        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
