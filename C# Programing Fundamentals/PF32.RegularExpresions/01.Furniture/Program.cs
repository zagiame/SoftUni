using System;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            //static
            string pattern = @">>([A-Za-z]+)<<(\d+\.*\d*)!(\d+)";
            var valid = new Regex(pattern);

            //input
            string input = string.Empty;

            // calculation
            double sum = 0;

            Console.WriteLine("Bought furniture:");

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = valid.Match(input);

                if (match.Success == true)
                {
                    string name = match.Groups[1].Value;
                    double price = double.Parse(match.Groups[2].Value);
                    int count = int.Parse(match.Groups[3].Value);

                    sum = sum + (price * count);

                    Console.WriteLine(name);
                }
            }

            //output
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
