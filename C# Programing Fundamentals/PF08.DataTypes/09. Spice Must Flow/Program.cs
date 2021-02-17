using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int startingYield = int.Parse(Console.ReadLine());

            // calculation
            int counter = 0;
            int spiceLeft = 0;
            int expectedYield = startingYield;

            while (expectedYield >= 100)
            {
                counter++;
                spiceLeft = spiceLeft + expectedYield - 26;
                expectedYield = expectedYield - 10;
            }

            if (spiceLeft > expectedYield)
            {
                spiceLeft = spiceLeft - 26;
            }

            // output
            Console.WriteLine(counter);
            Console.WriteLine(spiceLeft);
        }
    }
}
