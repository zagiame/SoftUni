using System;

namespace FootballTeamGenerator
{
    public class Player
    {
        // constant
        private const int minStatValue = 0;
        private const int maxStatValue = 100;

        // field
        private string nameField;
        private int enduranceField;
        private int sprintField;
        private int dribbleField;
        private int passingField;
        private int shootingField;

        // constructor
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
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

        public int Endurance
        {
            get => this.enduranceField;

            private set
            {
                Validator.ThrowIfNumberIsNotInRange(minStatValue, maxStatValue, value,
                    $"{nameof(this.Endurance)} should be between {minStatValue} and {maxStatValue}.");

                this.enduranceField = value;
            }
        }

        public int Sprint
        {
            get => this.sprintField;

            private set
            {
                Validator.ThrowIfNumberIsNotInRange(minStatValue, maxStatValue, value,
                    $"{nameof(this.Sprint)} should be between {minStatValue} and {maxStatValue}.");

                this.sprintField = value;
            }
        }

        public int Dribble
        {
            get => this.dribbleField;

            private set
            {
                Validator.ThrowIfNumberIsNotInRange(minStatValue, maxStatValue, value,
                    $"{nameof(this.Dribble)} should be between {minStatValue} and {maxStatValue}.");

                this.dribbleField = value;
            }
        }

        public int Passing
        {
            get => this.passingField;

            private set
            {
                Validator.ThrowIfNumberIsNotInRange(minStatValue, maxStatValue, value,
                    $"{nameof(this.Passing)} should be between {minStatValue} and {maxStatValue}.");

                this.passingField = value;
            }
        }

        public int Shooting
        {
            get => this.shootingField;

            private set
            {
                Validator.ThrowIfNumberIsNotInRange(minStatValue, maxStatValue, value,
                    $"{nameof(this.Shooting)} should be between {minStatValue} and {maxStatValue}.");

                this.shootingField = value;
            }
        }

        public double AverageSkillPoints =>
            Math.Round((this.Endurance +
                        this.Sprint +
                        this.Dribble +
                        this.Passing +
                        this.Shooting) / 5.0);

        // method
    }
}