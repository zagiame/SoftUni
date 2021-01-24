using System;
using System.Collections.Generic;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = string.Empty;

            // calculation
            var list = new SortedDictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] currentLine = input.Split(" -> ");
                string company = currentLine[0];
                string id = currentLine[1];

                if (list.ContainsKey(company) == false)
                {
                    list.Add(company, new List<string>());
                }

                if (list[company].Contains(id) == false)
                {
                    list[company].Add(id);
                }
            }

            // output
            foreach (var item in list)
            {
                Console.WriteLine(item.Key);

                foreach (var ID in list[item.Key])
                {
                    Console.WriteLine($"-- {ID}");
                }
            }
        }
    }
}
