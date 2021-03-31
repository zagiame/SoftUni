using System;
using System.Collections.Generic;
using System.Linq;
using FoodShortage;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main()
        {
            // input
            var n = int.Parse(Console.ReadLine());

            // calculation
            string input = string.Empty;
            var buyersByName = new Dictionary<string, IBuyer>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                var data = input.Split();
                var name = data[0];
                var age = int.Parse(data[1]);

                if (data.Length == 3)
                {
                    var gang = data[2];
                    buyersByName[name] = (new Rebel(name, age, gang));
                }

                else if (data.Length == 4)
                {
                    var personID = data[2];
                    var birthday = data[3];

                    buyersByName[name] = (new Citizen(name, age, personID, birthday));
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                var data = input;

                if (buyersByName.ContainsKey(data))
                {
                    buyersByName[data].BuyFood();
                }

            }

            // output
            var sum = buyersByName.Values.Sum(first => first.Food);

            Console.WriteLine(sum);
        }
    }
}