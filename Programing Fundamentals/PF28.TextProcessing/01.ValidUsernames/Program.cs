using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string[] input = Console.ReadLine().Split(", ");

            // calculation
            var regexItem = new Regex(@"^[a-zA-Z0-9]+$");

            // output
            foreach (var item in input)
            {
                bool isValid = item.Length >= 3
                               && item.Length <= 16
                               && regexItem.IsMatch(item)
                               || item.Contains('-')
                               || item.Contains('_');

                if (isValid)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
