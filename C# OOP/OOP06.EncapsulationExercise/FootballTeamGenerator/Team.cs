using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        // field
        private string nameField;
        private int ratingField;
        private Dictionary<string, Player> playersByNameField;

        // constructor
        public Team(string name)
        {
            this.Name = name;
            this.playersByNameField = new Dictionary<string, Player>();
        }

        // property
        public string Name
        {
            get => this.nameField;
            private set
            {
                Validator.ThrowIfEmptyOrWhiteSpace(value, GlobalConstants.InvalidNameErrorMessage);
                this.nameField = value;
            }
        }

        public double AverageRating
        {
            get
            {
                if (this.playersByNameField.Count == 0)
                {
                    return 0;
                }

                return Math.Round(this.playersByNameField.Values.Average(player => player.AverageSkillPoints));
            }
        }

        // method
        public void AddPlayer(Player player)
        {
            this.playersByNameField.Add(player.Name, player);
        }

        public void RemovePlayer(string playerName)
        {
            if (this.playersByNameField.ContainsKey(playerName))
            {
                this.playersByNameField.Remove(playerName);
            }

            else
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }
        }
    }
}