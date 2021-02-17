using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            // validation

            string pattern = @"@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+";
            string patternNumbers = @"\d";

            var validator = new Regex(pattern);
            var validNumbers = new Regex(patternNumbers);

            // input
            int numberOfInputs = int.Parse(Console.ReadLine());

            // calculation

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                Match matchBarcode = validator.Match(input);

                if (matchBarcode.Success == false)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                var matchNumbers = validNumbers.Matches(matchBarcode.Value);
                string group = string.Empty;

                foreach (var item in matchNumbers)
                {
                    group = group + item;
                }

                if (group == string.Empty)
                {
                    group = "00";
                }

                Console.WriteLine($"Product group: {group}");
            }

        }
    }
}
