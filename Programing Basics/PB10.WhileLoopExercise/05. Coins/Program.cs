using System;
using System.Xml;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double change = double.Parse(Console.ReadLine());
            double coinsCount = 0;
            double convert = (double)change * 100;
            int cent = (int)convert;

            while (cent > 0)
            {
                coinsCount++;

                if (cent >= 200)
                {
                    cent = cent - 200;
                }

                else if (cent >= 100)
                {
                    cent = cent - 100;
                }

                else if (cent >= 50)
                {
                    cent = cent - 50;
                }

                else if (cent >= 20)
                {
                    cent = cent - 20;
                }

                else if (cent >= 10)
                {
                    cent = cent - 10;
                }

                else if (cent >= 5)
                {
                    cent = cent - 5;
                }

                else if (cent >= 2)
                {
                    cent = cent - 2;
                }

                else if (cent >= 1)
                {
                    cent = cent - 1;
                }

                if (cent == 0)
                {
                    Console.WriteLine($"{coinsCount}");
                    break;
                }

            }

        }
    }
}
