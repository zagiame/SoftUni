using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = string.Empty;

            // calculation
            var setExam = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] commnad = input.Split(":");
                string contest = commnad[0];
                string pass = commnad[1];

                if (setExam.ContainsKey(contest) == false)
                {
                    setExam.Add(contest, pass);
                }
            }

            var setUser = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] commnad = input.Split("=>");
                string contest = commnad[0];
                string pass = commnad[1];
                string user = commnad[2];
                int points = int.Parse(commnad[3]);

                if (setExam.ContainsKey(contest) && setExam[contest] == pass)
                {
                    if (setUser.ContainsKey(user) == false)
                    {
                        setUser.Add(user, new Dictionary<string, int>());
                    }

                    if (setUser[user].ContainsKey(contest) == false)
                    {
                        setUser[user].Add(contest, 0);
                    }

                    if (setUser[user][contest] < points)
                    {
                        setUser[user][contest] = points;
                    }

                }

            }

            // output

            string bestCandidate = string.Empty;
            int bestCandidateScore = 0;

            foreach (var user in setUser)
            {
                int score = 0;

                foreach (var exam in user.Value)
                {
                    score = score + exam.Value;
                }

                if (score > bestCandidateScore)
                {
                    bestCandidateScore = score;
                    bestCandidate = user.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidateScore} points.");
            Console.WriteLine("Ranking:");

            foreach (var item in setUser.OrderBy(first => first.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var exam in item.Value.OrderByDescending(first => first.Value))
                {
                    Console.WriteLine($"#  {exam.Key} -> {exam.Value}");
                }
            }
        }
    }
}
