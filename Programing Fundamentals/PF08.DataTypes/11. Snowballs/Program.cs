using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int nNumberSnowballs = int.Parse(Console.ReadLine());

            // calculation
            BigInteger winingValue = 0;
            int winingSnow = 0;
            int winingTime = 0;
            int winingQuality = 0;

            for (int i = 0; i < nNumberSnowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quaility = int.Parse(Console.ReadLine());

                int divide = snow / time;
                BigInteger currentValue = BigInteger.Pow(divide, quaility);

                if (winingValue <= currentValue)
                {
                    winingSnow = snow;
                    winingTime = time;
                    winingQuality = quaility;
                    winingValue = currentValue;
                }
            }

            // output
            Console.WriteLine($"{winingSnow} : {winingTime} = {winingValue} ({winingQuality})");
        }
    }
}
