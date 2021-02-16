using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var ingredient = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            // calculation
            var food = new Dictionary<string, int>();
            food.Add("Bread", 0);
            food.Add("Cake", 0);
            food.Add("Pastry", 0);
            food.Add("Fruit Pie", 0);

            while (liquids.Count > 0 && ingredient.Count > 0)
            {
                int sum = 0;
                int currentLiquid = liquids.Dequeue();
                int currentIngridient = ingredient.Pop();

                sum = currentLiquid + currentIngridient;

                if (sum == 25)
                {
                    food["Bread"]++;
                }

                else if (sum == 50)
                {
                    food["Cake"]++;
                }

                else if (sum == 75)
                {
                    food["Pastry"]++;
                }

                else if (sum == 100)
                {
                    food["Fruit Pie"]++;
                }

                else
                {
                    currentIngridient = currentIngridient + 3;
                    ingredient.Push(currentIngridient);
                }
            }

            // output
            bool isCookingSuccessful =
                food["Bread"] != 0
                && food["Cake"] != 0
                && food["Pastry"] != 0
                && food["Fruit Pie"] != 0;

            if (isCookingSuccessful == true)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }

            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count > 0)
            {
                string toPrint = "Liquids left: " + string.Join(", ", liquids);
                Console.WriteLine(toPrint);
            }

            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingredient.Count > 0)
            {
                string toPrint = "Ingredients left: " + string.Join(", ", ingredient);
                Console.WriteLine(toPrint);
            }

            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            foreach (var item in food.OrderBy(first => first.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
