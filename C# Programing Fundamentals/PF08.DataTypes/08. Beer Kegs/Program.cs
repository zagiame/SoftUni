using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int number = int.Parse(Console.ReadLine());

            // calcuclation
            string winnerName = string.Empty;
            double winnerVolume = 0;

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > winnerVolume)
                {
                    winnerName = name;
                    winnerVolume = volume;
                }
            }

            // output
            Console.WriteLine(winnerName);
        }
    }
}
