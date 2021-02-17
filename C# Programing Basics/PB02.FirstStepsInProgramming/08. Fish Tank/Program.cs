using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            // static data

            // input
            double sizeX = double.Parse(Console.ReadLine());
            double sizeY = double.Parse(Console.ReadLine());
            double sizeZ = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            // calculation
            double volume = sizeX * sizeY * sizeZ;
            double waterM3 = volume * 0.001;
            double percentM3 = percent * 0.01;
            double totalWater = waterM3 * (1 - percentM3);

            // output
            Console.WriteLine(totalWater);
        }
    }
}
