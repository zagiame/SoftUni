using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double vacationPrice = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            // calculation
            int dayCounter = 0;
            int dayInRowSpending = 0;

            while (currentMoney < vacationPrice)
            {
                dayCounter++;
                string operation = Console.ReadLine();
                double operationMoney = double.Parse(Console.ReadLine());

                if (operation == "spend")
                {
                    dayInRowSpending++;
                    currentMoney = currentMoney - operationMoney;

                    if (currentMoney < 0)
                    {
                        currentMoney = 0;
                    }

                    if (dayInRowSpending == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{dayCounter}");
                        break;
                    }

                }

                else
                {
                    dayInRowSpending = 0;
                    currentMoney = currentMoney + operationMoney;

                    if (currentMoney >= vacationPrice)
                    {
                        Console.WriteLine($"You saved the money for {dayCounter} days.");
                    }
                }

            }

        }
    }
}
