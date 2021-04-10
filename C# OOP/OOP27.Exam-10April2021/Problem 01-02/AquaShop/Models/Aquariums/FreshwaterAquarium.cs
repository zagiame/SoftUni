namespace AquaShop.Models.Aquariums
{
    public class FreshwaterAquarium : Aquarium
    {
        private const int freshwaterCapacity = 50;

        public FreshwaterAquarium(string name)
            : base(name, freshwaterCapacity)
        {

        }
    }
}