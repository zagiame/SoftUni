using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Dough
    {
        // constant
        private const int BaseCalories = 2;
        private const int MinWeight = 1;
        private const int MaxWeight = 200;
        private const string InvalidDoughExceptionMessage = "Invalid type of dough.";

        // field
        private string flourType;
        private string bakingTechnique;
        private int weight;

        // constructor
        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        // property
        public string FlourType
        {
            get => this.flourType;

            private set
            {
                var allowedValues = new HashSet<string> { "white", "wholegrain" };
                Validator.ThrowIfValueIsNotAllowed(allowedValues, value.ToLower(), InvalidDoughExceptionMessage);

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;

            private set
            {
                var allowedValues = new HashSet<string> { "chewy", "crispy", "homemade" };
                Validator.ThrowIfValueIsNotAllowed(allowedValues, value.ToLower(), InvalidDoughExceptionMessage);

                this.bakingTechnique = value;
            }

        }

        public int Weight
        {
            get => this.weight;

            private set
            {
                Validator.ThrowIfNumberIsNotInRange(MinWeight, MaxWeight, value,
                    $"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");

                this.weight = value;
            }
        }

        // method
        public double GetCalories()
        {
            var flourTypeModifier = GetFlourTypeModifier();
            var bakingTechniqueModifier = GetBakingTechniqueModifier();

            return this.Weight * BaseCalories * flourTypeModifier * bakingTechniqueModifier;
        }

        private double GetFlourTypeModifier()
        {
            var flourTypeLower = this.FlourType.ToLower();

            if (flourTypeLower == "white")
            {
                return 1.5;
            }

            return 1;
        }

        private double GetBakingTechniqueModifier()
        {
            var bakingTechniqueLower = this.bakingTechnique.ToLower();

            if (bakingTechniqueLower == "chewy")
            {
                return 1.1;
            }

            if (bakingTechniqueLower == "crispy")
            {
                return 0.9;
            }

            return 1;
        }

    }
}