using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Repositories.Contracts;
using AquaShop.Utilities.Messages;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IDecoration> decorantionRepository;
        private Dictionary<string, IAquarium> aquariumByName;

        public Controller()
        {
            decorantionRepository = new DecorationRepository();
            aquariumByName = new Dictionary<string, IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium = null;

            if (aquariumType != nameof(FreshwaterAquarium) && aquariumType != nameof(SaltwaterAquarium))
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }

            if (aquariumType == nameof(FreshwaterAquarium))
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }

            else if (aquariumType != nameof(SaltwaterAquarium))
            {
                aquarium = new SaltwaterAquarium(aquariumName);
            }

            aquariumByName.Add(aquariumName, aquarium);
            return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration = null;

            if (decorationType != nameof(Ornament) && decorationType != nameof(Plant))
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            if (decorationType == nameof(Ornament))
            {
                decoration = new Ornament();
            }

            else if (decorationType != nameof(Plant))
            {
                decoration = new Plant();
            }

            decorantionRepository.Add(decoration);
            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            var decoration = decorantionRepository.FindByType(decorationType);

            if (decoration == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration,
                    decorationType));
            }

            aquariumByName[aquariumName].AddDecoration(decoration);
            decorantionRepository.Remove(decoration);

            return string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IFish fish = null;

            if (fishType != nameof(FreshwaterFish) && fishType != nameof(SaltwaterFish))
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }

            if (fishType == nameof(FreshwaterFish))
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }

            else if (fishType != nameof(SaltwaterAquarium))
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }

            var aquariumType = aquariumByName[aquariumName].GetType().Name;

            if (aquariumType == nameof(SaltwaterAquarium) && fishType == nameof(FreshwaterFish)
            || aquariumType == nameof(FreshwaterAquarium) && fishType == nameof(SaltwaterFish))
            {
                throw new InvalidOperationException(OutputMessages.UnsuitableWater);
            }

            aquariumByName[aquariumName].AddFish(fish);
            return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
        }

        public string FeedFish(string aquariumName)
        {
            aquariumByName[aquariumName].Feed();
            var count = aquariumByName[aquariumName].Fish.Count;

            return string.Format(OutputMessages.FishFed, count);
        }

        public string CalculateValue(string aquariumName)
        {
            var sumFish = aquariumByName[aquariumName].Fish.Sum(f => f.Price);
            var sumDecoration = aquariumByName[aquariumName].Decorations.Sum(d => d.Price);

            var sumToReturn = sumFish + sumDecoration;
            return string.Format(OutputMessages.AquariumValue, aquariumName, sumToReturn);
        }

        public string Report()
        {
            var text = new StringBuilder();

            foreach (var aquarium in aquariumByName.Values)
            {
                text.AppendLine(aquarium.GetInfo());
            }

            return text.ToString().TrimEnd();
        }
    }
}