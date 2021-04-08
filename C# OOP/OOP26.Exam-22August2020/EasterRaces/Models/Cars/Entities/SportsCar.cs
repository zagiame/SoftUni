namespace EasterRaces.Models.Cars.Entities
{
    public class SportsCar : Car
    {
        private const double defaultCubicCentimeters = 3000;
        private const int defaultMinHorsePower = 250;
        private const int defaultMaxHorsePower = 450;

        public SportsCar(string model, int horsePower)
            : base(model, horsePower, defaultCubicCentimeters, defaultMinHorsePower, defaultMaxHorsePower)
        {

        }
    }
}