using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = string.Empty;

            // calculation
            var participants = new List<Trainer>();

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] inputData = input.Split();
                string trainerName = inputData[0];
                string pokemonName = inputData[1];
                string pokemonElement = inputData[2];
                int pokemonHealth = int.Parse(inputData[3]);
                int numberOfBadges = 0;


                var trainer = participants.FirstOrDefault(x => x.Name == trainerName);
                if (trainer != null)
                {
                    trainer.CollectionOfPokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                }
                else
                {
                    var currentTrainer = new Trainer(trainerName, numberOfBadges, new List<Pokemon>());
                    currentTrainer.CollectionOfPokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                    participants.Add(currentTrainer);
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                ParticipantChecker(input, participants);
            }

            foreach (var item in participants)
            {
                item.CollectionOfPokemons.RemoveAll(x => x.Health <= 0);
            }

            // output
            foreach (var player in participants.OrderByDescending(first => first.NumberOfBadges))
            {
                Console.WriteLine($"{player.Name} {player.NumberOfBadges} {player.CollectionOfPokemons.Count}");
            }
        }

        private static void ParticipantChecker(string elementToCompare, List<Trainer> participants)
        {
            foreach (var player in participants)
            {
                if (PokemonChecker(player, elementToCompare) == true)
                {
                    player.NumberOfBadges++;
                }

                else
                {
                    RemoveHealth(player);
                }
            }
        }

        private static void RemoveHealth(Trainer player)
        {
            var remove = new List<string>();

            foreach (var pokemon in player.CollectionOfPokemons)
            {
                pokemon.Health = pokemon.Health - 10;
            }
        }

        private static bool PokemonChecker(Trainer player, string elementToCompare)
        {
            foreach (var pokemon in player.CollectionOfPokemons)
            {
                if (pokemon.Element.Equals(elementToCompare))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> CollectionOfPokemons { get; set; }

        public Trainer(string name, int badges, List<Pokemon> collection)
        {
            this.Name = name;
            this.NumberOfBadges = badges;
            this.CollectionOfPokemons = collection;
        }
    }

    public class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }

        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
    }
}
