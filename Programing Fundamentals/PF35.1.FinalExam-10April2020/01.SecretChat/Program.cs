using System;
using System.Linq;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string message = Console.ReadLine();

            // calculation
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] command = input.Split(":|:");
                string action = command[0];

                if (action == "InsertSpace")
                {
                    int index = int.Parse(command[1]);

                    message = message.Insert(index, " ");
                }

                else if (action == "Reverse")
                {
                    string substring = command[1];

                    if (message.Contains(substring) == true)
                    {
                        int index = message.IndexOf(substring);
                        substring = Reverse(substring);

                        message = message.Remove(index, substring.Length);
                        message = message.Insert(message.Length, substring);

                    }

                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                }

                else if (action == "ChangeAll")
                {
                    string substring = command[1];
                    string replacement = command[2];

                    message = message.Replace(substring, replacement);
                }

                Console.WriteLine(message);
            }

            // output
            Console.WriteLine($"You have a new text message: {message}");
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
