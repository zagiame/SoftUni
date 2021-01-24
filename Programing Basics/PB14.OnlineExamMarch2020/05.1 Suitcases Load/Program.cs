using System;

namespace _05._1_Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double loadCapacity = double.Parse(Console.ReadLine());

            // calculation
            string operation = Console.ReadLine();
            double bagCounter = 0;

            while (operation != "End")
            {
                bagCounter++;
                double bagSize = double.Parse(operation);

                if (bagCounter % 3 == 0)
                {
                    bagSize = bagSize + (bagSize * 0.10);
                }

                loadCapacity = loadCapacity - bagSize;

                if (loadCapacity < 0)
                {
                    bagCounter = bagCounter - 1;
                    Console.WriteLine("No more space!");
                    break;
                }

                operation = Console.ReadLine();
            }

            // output

            if (operation == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {bagCounter} suitcases loaded.");
        }
    }
}
