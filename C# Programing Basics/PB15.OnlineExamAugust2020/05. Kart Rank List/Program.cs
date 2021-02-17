using System;

namespace _05._Kart_Rank_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string operation = Console.ReadLine();

            // calculation
            double goldCard = 55;
            double silverCard = 1 * 60 + 25;
            double bronzeCard = 2 * 60;
            double counterGold = 0;
            double counterSilver = 0;
            double counterBronze = 0;
            string nameOfWinner = "";
            double minutesOfWinner = 0;
            double secondsOfWinner = 0;
            double winnerTimerInSeconds = 0;


            while (operation != "Finish")
            {
                string name = operation;
                double minutes = double.Parse(Console.ReadLine());
                double seconds = double.Parse(Console.ReadLine());
                double totalTimeinSeconds = minutes * 60 + seconds;

                if (totalTimeinSeconds < goldCard)
                {
                    counterGold++;
                }

                else if (totalTimeinSeconds >= goldCard && totalTimeinSeconds <= silverCard)
                {
                    counterSilver++;
                }

                else if (totalTimeinSeconds < bronzeCard)
                {
                    counterBronze++;
                }

                if (winnerTimerInSeconds >= totalTimeinSeconds || winnerTimerInSeconds == 0)
                {
                    winnerTimerInSeconds = totalTimeinSeconds;
                    nameOfWinner = operation;
                    minutesOfWinner = totalTimeinSeconds / 60;
                    secondsOfWinner = totalTimeinSeconds % 60;
                }

                operation = Console.ReadLine();
            }

            // output
            Console.WriteLine($"With {Math.Floor(minutesOfWinner)} minutes and {secondsOfWinner} seconds {nameOfWinner} is the winner of the day!");
            Console.WriteLine($"Today's prizes are {counterGold} Gold {counterSilver} Silver and {counterBronze} Bronze cards!");

        }
    }
}
