using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<int> deckOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deckTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            // calculation

            while (deckOne.Count != 0 && deckTwo.Count != 0)
            {
                int PlayerOneCard = deckOne[0];
                int PlayerTwoCard = deckTwo[0];

                if (PlayerOneCard > PlayerTwoCard)
                {
                    deckOne.Add(PlayerOneCard);
                    deckOne.Add(PlayerTwoCard);
                }

                else if (PlayerOneCard < PlayerTwoCard)
                {
                    deckTwo.Add(PlayerTwoCard);
                    deckTwo.Add(PlayerOneCard);
                }

                deckOne.RemoveAt(0);
                deckTwo.RemoveAt(0);
            }

            // output
            if (deckOne.Count > deckTwo.Count)
            {
                Console.WriteLine($"First player wins! Sum: {deckOne.Sum()}");
            }

            else if (deckOne.Count < deckTwo.Count)
            {
                Console.WriteLine($"Second player wins! Sum: {deckTwo.Sum()}");
            }

        }
    }
}
