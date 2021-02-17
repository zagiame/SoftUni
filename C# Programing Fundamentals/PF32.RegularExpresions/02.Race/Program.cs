using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            // static
            string namePattern = @"[\W\d]";
            string distancePattern = @"[\D]";

            var name = new Regex(namePattern);
            var distance = new Regex(distancePattern);

            // input
            string[] participants = Console.ReadLine().Split(", ");
            string input = string.Empty;

            // calculation
            var score = new Dictionary<string, int>();

            foreach (var item in participants)
            {
                score.Add(item, 0);
            }

            while ((input = Console.ReadLine()) != "end of race")
            {
                string currentName = name.Replace(input, "");
                string currentDistance = distance.Replace(input, "");

                if (score.ContainsKey(currentName) == false)
                {
                    continue;
                }

                foreach (int item in currentDistance)
                {
                    score[currentName] = score[currentName] + item;
                }
            }

            // output
            int count = 0;

            foreach (var item in score.OrderByDescending(first => first.Value))
            {

                if (count++ >= 3)
                {
                    break;
                }

                string text = count == 1 ? "st"
                            : count == 2 ? "nd"
                            : "rd";

                Console.WriteLine($"{count}{text} place: {item.Key}");
            }
        }
    }
}
