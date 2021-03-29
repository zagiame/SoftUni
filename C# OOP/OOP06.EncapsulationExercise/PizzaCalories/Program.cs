using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main()
        {
            try
            {
                var pizzaNameData = Console.ReadLine().Split();
                var pizzaName = pizzaNameData[1];

                var doughData = Console.ReadLine().Split();
                var flourType = doughData[1];
                var bakingTechnique = doughData[2];
                var weight = int.Parse(doughData[3]);

                var dough = new Dough(flourType, bakingTechnique, weight);
                var pizza = new Pizza(pizzaName, dough);

                string commnad = string.Empty;

                while ((commnad = Console.ReadLine()) != "END")
                {
                    var data = commnad.Split();
                    var toppingName = data[1];
                    var toppingWeight = int.Parse(data[2]);

                    var topping = new Topping(toppingName, toppingWeight);
                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
