namespace WildFarm
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public abstract void ProduceSound();
        public abstract void EatFood(string food, int quantity);
    }
}