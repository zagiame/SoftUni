using System;
using System.Linq;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var input = Console.ReadLine();

            // calculation
            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var item = input[i];

                if (item == '>')
                {
                    power = power + int.Parse(input[i + 1].ToString());
                    continue;
                }

                if (power > 0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    power--;
                }
            }

            // output
            Console.WriteLine(input);
        }
    }
}
