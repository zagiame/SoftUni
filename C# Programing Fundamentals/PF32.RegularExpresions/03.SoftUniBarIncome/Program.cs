using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            // validation

            string pattern = @"%([A-z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+\.?\d*)\$";

            var validator = new Regex(pattern);

            // input
            string input = string.Empty;

            // calculation
            double totalSum = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = validator.Match(input);

                if (match.Success == true)
                {
                    string name = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    double count = double.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);

                    double sum = count * price;
                    totalSum = totalSum + sum;

                    Console.WriteLine($"{name}: {product} - {sum:f2}");
                }
            }

            // output
            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
