using System;

namespace _01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string message = Console.ReadLine();

            // calculation
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] command = input.Split('|');
                string action = command[0];

                if (action == "Move")
                {
                    int numberOfLetters = int.Parse(command[1]);
                    string temp = message.Substring(0, numberOfLetters);

                    message = message.Remove(0, numberOfLetters) + temp;
                }

                else if (action == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];

                    message = message.Insert(index, value);
                }

                else if (action == "ChangeAll")
                {
                    string substring = command[1];
                    string replacement = command[2];

                    message = message.Replace(substring, replacement);
                }
            }

            // output
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
