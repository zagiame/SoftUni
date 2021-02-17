using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumber = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double devide2 = 0;
            double devide3 = 0;
            double devide4 = 0;

            for (int i = 0; i < countNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    devide2++;
                    p1 = devide2 / countNumber * 100;
                }

                if (number % 3 == 0)
                {
                    devide3++;
                    p2 = devide3 / countNumber * 100;
                }

                if (number % 4 == 0)
                {
                    devide4++;
                    p3 = devide4 / countNumber * 100;
                }
            }

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
