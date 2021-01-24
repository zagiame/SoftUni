using System;
using System.Dynamic;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string favoriteBook = Console.ReadLine();

            // calculation
            int counter = 0;
            bool isBookFound = false;

            string nextBookName = Console.ReadLine();

            while (nextBookName != "No More Books")
            {
                if (nextBookName == favoriteBook)
                {
                    isBookFound = true;
                    break;
                }

                counter++;
                nextBookName = Console.ReadLine();
            }

            // output
            if (isBookFound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }

            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }

        }
    }
}
