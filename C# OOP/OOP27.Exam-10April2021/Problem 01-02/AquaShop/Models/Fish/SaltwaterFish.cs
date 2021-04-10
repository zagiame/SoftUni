namespace AquaShop.Models.Fish
{
    public class SaltwaterFish : Fish
    {
        private const int saltwaterFishSize = 5;

        public SaltwaterFish(string name, string species, decimal price)
            : base(name, species, price)
        {
            this.Size = saltwaterFishSize;
        }

        public override void Eat()
        {
            this.Size += 2;
        }
    }
}