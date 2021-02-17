using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Guild
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Initialize the repository (guild)
            Guild guild = new Guild("Weekend Raiders", 20);
            //Initialize entity
            Player player = new Player("Mark", "Rogue");
            //Print player
            Console.WriteLine(player); //Player Mark: Rogue
                                       //Rank: Trial
                                       //Description: n/a

            //Add player
            guild.AddPlayer(player);
            Console.WriteLine(guild.Count); //1
            Console.WriteLine(guild.RemovePlayer("Gosho")); //False

            Player firstPlayer = new Player("Pep", "Warrior");
            Player secondPlayer = new Player("Lizzy", "Priest");
            Player thirdPlayer = new Player("Mike", "Rogue");
            Player fourthPlayer = new Player("Marlin", "Mage");

            //Add description to player
            secondPlayer.Description = "Best healer EU";

            //Add players
            guild.AddPlayer(firstPlayer);
            guild.AddPlayer(secondPlayer);
            guild.AddPlayer(thirdPlayer);
            guild.AddPlayer(fourthPlayer);

            //Promote player
            guild.PromotePlayer("Lizzy");

            //RemovePlayer
            Console.WriteLine(guild.RemovePlayer("Pep")); //True

            Player[] kickedPlayers = guild.KickPlayersByClass("Rogue");
            Console.WriteLine(string.Join(", ", kickedPlayers.Select(p => p.Name))); //Mark, Mike

            Console.WriteLine(guild.Report());
            //Players in the guild: Weekend Raiders
            //Player Lizzy: Priest
            //Rank: Member
            //Description: Best healer EU
            //Player Marlin: Mage
            //Rank: Trial
            //Description: n/a
        }

        class Player
        {
            // constructor
            public Player(string ctorName, string ctorClass)
            {
                Name = ctorName;
                Class = ctorClass;
                Rank = "Trial";
                Description = "n/a";
            }

            // property
            public string Name { get; set; }
            public string Class { get; set; }
            public string Rank { get; set; }
            public string Description { get; set; }

            // method
            public override string ToString()
            {
                StringBuilder text = new StringBuilder();

                text.AppendLine($"Player {Name}: {Class}");
                text.AppendLine($"Rank: {Rank}");
                text.Append($"Description: {Description}");

                return text.ToString();
            }
        }

        class Guild
        {
            // filed
            private List<Player> roster;

            // constructor
            public Guild(string ctorName, int ctorCapacity)
            {
                roster = new List<Player>();
                Name = ctorName;
                Capacity = ctorCapacity;
            }

            // property
            public string Name { get; set; }
            public int Capacity { get; set; }
            public int Count { get => roster.Count(); }

            // method
            public void AddPlayer(Player player)
            {
                if (roster.Count < Capacity)
                {
                    roster.Add(player);
                }
            }

            public bool RemovePlayer(string name)
            {
                Player player = roster.FirstOrDefault(first => first.Name == name);
                bool isPresent = roster.Remove(player);

                return isPresent;
            }

            public void PromotePlayer(string name)
            {
                Player player = roster.FirstOrDefault(first => first.Name == name);

                if (player != null)
                {
                    player.Rank = "Member";
                }
            }

            public void DemotePlayer(string name)
            {
                Player player = roster.FirstOrDefault(first => first.Name == name);

                if (player != null)
                {
                    player.Rank = "Trial";
                }
            }

            public Player[] KickPlayersByClass(string methodClass)
            {
                List<Player> myListTemp = new List<Player>();

                foreach (var player in roster)
                {
                    if (player.Class == methodClass)
                    {
                        myListTemp.Add(player);
                    }
                }

                Player[] myArrayToReturn = myListTemp.ToArray();

                roster = roster.Where(x => x.Class != methodClass).ToList();

                return myArrayToReturn;
            }

            public string Report()
            {
                StringBuilder text = new StringBuilder();

                text.AppendLine($"Players in the guild: {Name}");

                foreach (var item in roster)
                {
                    text.AppendLine(item.ToString());
                }

                return text.ToString();
            }
        }
    }
}
