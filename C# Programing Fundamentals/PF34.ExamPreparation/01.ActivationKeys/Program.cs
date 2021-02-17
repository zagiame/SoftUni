using System;
using System.Text;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string activationKey = Console.ReadLine();

            // calculation
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] operation = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = operation[0];
                string action = operation[1];

                if (command == "Contains")
                {
                    if (activationKey.Contains(action) == true)
                    {
                        Console.WriteLine($"{activationKey} contains {action}");
                    }

                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                else if (command == "Flip")
                {
                    int startIndex = int.Parse(operation[2]);
                    int endIndex = int.Parse(operation[3]);

                    string fisrtPart = activationKey.Substring(0, startIndex);
                    string secondPart = activationKey.Substring(startIndex, endIndex - startIndex);
                    string thirdPart = activationKey.Substring(endIndex);

                    if (action == "Upper")
                    {
                        secondPart = secondPart.ToUpper();
                    }

                    else
                    {
                        secondPart = secondPart.ToLower();
                    }

                    activationKey = fisrtPart + secondPart + thirdPart;
                    Console.WriteLine(activationKey);
                }

                else
                {
                    int startIndex = int.Parse(operation[1]);
                    int endIndex = int.Parse(operation[2]);

                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }

            // output
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
