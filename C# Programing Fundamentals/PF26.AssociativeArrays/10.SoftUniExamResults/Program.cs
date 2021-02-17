using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string input = string.Empty;

            // calculation
            var exam = new Dictionary<string, int>();
            var counter = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] currentLine = input.Split('-');
                string user = currentLine[0];
                string language = currentLine[1];

                if (language != "banned")
                {
                    int score = int.Parse(currentLine[2]);

                    //////////////////////////////////////////////////////

                    if (exam.ContainsKey(user) == false)
                    {
                        exam.Add(user, score);
                    }

                    if (exam[user] < score)
                    {
                        exam[user] = score;
                    }

                    //////////////////////////////////////////////////////

                    if (counter.ContainsKey(language) == false)
                    {
                        counter.Add(language, 0);
                    }

                    counter[language]++;

                    //////////////////////////////////////////////////////

                }

                else
                {
                    exam.Remove(user);
                }
            }

            // output

            Console.WriteLine("Results:");

            foreach (var item in exam.OrderByDescending(first => first.Value).ThenBy(second => second.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var item in counter.OrderByDescending(first => first.Value).ThenBy(second => second.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
