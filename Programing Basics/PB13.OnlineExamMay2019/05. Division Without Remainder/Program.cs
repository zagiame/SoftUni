using System;

namespace _05._Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double number = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            double counterP1 = 0;
            double counterP2 = 0;
            double counterP3 = 0;

            for (int i = 0; i < number; i++)
            {
                double input = double.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    counterP1++;
                    p1 = counterP1 / number * 100;

                }

                if (input % 3 == 0)
                {
                    counterP2++;
                    p2 = counterP2 / number * 100;
                }

                if (input % 4 == 0)
                {
                    counterP3++;
                    p3 = counterP3 / number * 100;
                }
            }

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
