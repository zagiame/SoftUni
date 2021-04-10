﻿namespace AquaShop.Models.Fish
{
    public class FreshwaterFish : Fish
    {
        private const int freshwaterFishSize = 3;

        public FreshwaterFish(string name, string species, decimal price)
            : base(name, species, price)
        {
            this.Size = freshwaterFishSize;
        }

        public override void Eat()
        {
            this.Size += 3;
        }
    }
}