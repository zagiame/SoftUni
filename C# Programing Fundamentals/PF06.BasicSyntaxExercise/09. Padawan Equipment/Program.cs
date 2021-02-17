using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaber = double.Parse(Console.ReadLine());
            double robe = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            // calculation
            lightsaber = ((students + Math.Ceiling(students * 0.10)) * lightsaber);
            robe = students * robe;
            double beltNumber = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    beltNumber++;
                }
            }

            beltPrice = (students - beltNumber) * beltPrice;
            double sum = lightsaber + robe + beltPrice;

            // output
            if (budget >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                double moneyNeeded = sum - budget;
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
