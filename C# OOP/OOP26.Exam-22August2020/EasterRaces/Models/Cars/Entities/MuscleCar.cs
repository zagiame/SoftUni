namespace EasterRaces.Models.Cars.Entities
{
    public class MuscleCar : Car
    {
        private const double defaultCubicCentimeters = 5000;
        private const int defaultMinHorsePower = 400;
        private const int defaultMaxHorsePower = 600;

        public MuscleCar(string model, int horsePower)
            : base(model, horsePower, defaultCubicCentimeters, defaultMinHorsePower, defaultMaxHorsePower)
        {

        }
    }
}