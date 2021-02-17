using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumber = int.Parse(Console.ReadLine());

            double number200 = 0;
            double number400 = 0;
            double number600 = 0;
            double number800 = 0;
            double number1000 = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 1; i <= countNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    number200++;
                    p1 = number200 / countNumber * 100;
                }

                else if (number < 400)
                {
                    number400++;
                    p2 = number400 / countNumber * 100;
                }

                else if (number < 600)
                {
                    number600++;
                    p3 = number600 / countNumber * 100;
                }

                else if (number < 800)
                {
                    number800++;
                    p4 = number800 / countNumber * 100;
                }

                else
                {
                    number1000++;
                    p5 = number1000 / countNumber * 100;
                }

            }

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
