using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MagicCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            List<string> cards = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> deck = new List<string>();

            // calculation
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Ready")
            {
                if (input == "Shuffle deck")
                {
                    deck.Reverse();
                }

                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string actin = command[0];
                string cardName = command[1];

                switch (actin)
                {
                    /////////////////////////////////////////////////////////
                    case "Add":

                        if (!cards.Contains(cardName))
                        {
                            Console.WriteLine("Card not found.");
                            continue;
                        }

                        deck.Add(cardName);

                        break;
                    /////////////////////////////////////////////////////////
                    case "Insert":

                        int index = int.Parse(command[2]);
                        bool isValid = cards.Contains(cardName) && index >= 0 && index < deck.Count();

                        if (!isValid)
                        {
                            Console.WriteLine("Error!");
                            continue;
                        }

                        deck.Insert(index, cardName);

                        break;
                    /////////////////////////////////////////////////////////
                    case "Remove":

                        if (!deck.Contains(cardName))
                        {
                            Console.WriteLine("Card not found.");
                            continue;
                        }

                        deck.Remove(cardName);

                        break;
                    /////////////////////////////////////////////////////////
                    case "Swap":

                        string tempCard = cardName;
                        string secondCard = command[2];
                        int firstCardIndex = deck.IndexOf(cardName);
                        int secondCardIndex = deck.IndexOf(secondCard);

                        deck[firstCardIndex] = secondCard;
                        deck[secondCardIndex] = tempCard;

                        break;
                    /////////////////////////////////////////////////////////
                    default:
                        break;
                }

            }

            // ouput
            Console.WriteLine(string.Join(' ', deck));
        }
    }
}
