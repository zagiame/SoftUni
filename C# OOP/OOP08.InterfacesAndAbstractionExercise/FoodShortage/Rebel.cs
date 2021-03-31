namespace FoodShortage
{
    public class Rebel : IPerson
    {
        public Rebel(string name, int age, string gang)
        {
            Name = name;
            Age = age;
            Gang = gang;
            Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Gang { get; set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}