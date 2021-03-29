using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = string.Empty;

            // calculation
            var teamsByName = new Dictionary<string, Team>();

            while ((input = Console.ReadLine()) != "END")
            {
                var data = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                var action = data[0];
                var teamName = data[1];

                try
                {
                    if (action == "Team")
                    {
                        var team = new Team(teamName);
                        teamsByName.Add(teamName, team);
                    }

                    else if (action == "Add")
                    {
                        if (teamsByName.ContainsKey(teamName) == false)
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }

                        else
                        {
                            var playerName = data[2];
                            var endurance = int.Parse(data[3]);
                            var sprint = int.Parse(data[4]);
                            var dribble = int.Parse(data[5]);
                            var passing = int.Parse(data[6]);
                            var shooting = int.Parse(data[7]);

                            var team = teamsByName[teamName];
                            var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                            team.AddPlayer(player);
                        }
                    }

                    else if (action == "Remove")
                    {
                        var playerName = data[2];

                        var team = teamsByName[teamName];
                        team.RemovePlayer(playerName);
                    }

                    else if (action == "Rating")
                    {
                        if (teamsByName.ContainsKey(teamName) == false)
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            var team = teamsByName[teamName];

                            Console.WriteLine($"{teamName} - {team.AverageRating}");
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
