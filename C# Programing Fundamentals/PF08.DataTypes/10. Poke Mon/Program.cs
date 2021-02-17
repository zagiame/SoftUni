using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int nPokePower = int.Parse(Console.ReadLine());
            int mDistance = int.Parse(Console.ReadLine());
            int yExhaustionFactor = int.Parse(Console.ReadLine());

            // calcucaltion
            int counter = 0;
            int powerLeft = nPokePower;
            double halfPower = nPokePower * 0.5;

            while (powerLeft >= mDistance)
            {
                counter++;
                powerLeft = powerLeft - mDistance;

                if (powerLeft == halfPower && yExhaustionFactor != 0)
                {
                    powerLeft = powerLeft / yExhaustionFactor;
                }
            }

            Console.WriteLine(powerLeft);
            Console.WriteLine(counter);
        }
    }
}
