namespace FoodShortage
{
    public class Citizen : IPerson
    {
        public Citizen(string name, int age, string id, string bDay)
        {
            Name = name;
            Age = age;
            ID = id;
            BDay = bDay;
            Food = 0;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string ID { get; private set; }

        public string BDay { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}