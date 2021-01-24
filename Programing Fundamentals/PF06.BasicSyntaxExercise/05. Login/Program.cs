using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string userName = Console.ReadLine();

            // calculation
            string password = string.Empty;
            int counter = 0;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password = password + userName[i];
            }

            while (true)
            {
                string currentCredentials = Console.ReadLine();

                if (currentCredentials == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }

                else if (currentCredentials != password)
                {
                    counter++;

                    if (counter >= 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                }

            }

        }
    }
}
