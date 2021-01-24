using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            double gameDuration = double.Parse(Console.ReadLine());

            // calculation
            double reward = 20;
            double moneyRaised = 0;
            double dailyWinCounter = 0;
            double dailyLoseCounter = 0;

            for (int i = 0; i < gameDuration; i++)
            {
                string operation = Console.ReadLine();
                double gameWinCounter = 0;
                double gameLoseCounter = 0;
                double moneyRaisedFor1Day = 0;

                while (operation != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        gameWinCounter++;
                        moneyRaisedFor1Day = moneyRaisedFor1Day + reward;
                    }

                    if (result == "lose")
                    {
                        gameLoseCounter++;
                    }

                    operation = Console.ReadLine();
                }

                if (gameWinCounter > gameLoseCounter)
                {
                    dailyWinCounter++;
                    moneyRaisedFor1Day = moneyRaisedFor1Day + (moneyRaisedFor1Day * 0.10);
                }

                if (gameWinCounter < gameLoseCounter)
                {
                    dailyLoseCounter++;
                }

                moneyRaised = moneyRaised + moneyRaisedFor1Day;

            }

            // output
            if (dailyWinCounter > dailyLoseCounter)
            {
                moneyRaised = moneyRaised + (moneyRaised * 0.20);
                Console.WriteLine($"You won the tournament! Total raised money: {moneyRaised:f2}");
            }

            if (dailyWinCounter < dailyLoseCounter)
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {moneyRaised:f2}");
            }
        }
    }
}
