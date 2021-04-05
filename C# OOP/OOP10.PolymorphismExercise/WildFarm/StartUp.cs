using System;
using System.Collections.Generic;

namespace WildFarm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            // input
            var input = string.Empty;

            // calculation
            var animalList = new List<Animal>();

            while ((input = Console.ReadLine()) != "End")
            {
                var animalData = input.Split();
                var animal = CreateAnimal(animalData);

                var foodData = Console.ReadLine().Split();
                var food = foodData[0];
                var quantity = int.Parse(foodData[1]);
                animal.EatFood(food, quantity);

                animalList.Add(animal);
            }

            // output
            foreach (var animal in animalList)
            {
                Console.WriteLine(animal);
            }

        }

        private static Animal CreateAnimal(string[] animalData)
        {
            Animal animalToReturn = null;
            var type = animalData[0];

            if (type == nameof(Owl) || type == nameof(Hen))
            {
                var name = animalData[1];
                var weight = double.Parse(animalData[2]);
                var wingSize = double.Parse(animalData[3]);

                if (type == nameof(Owl))
                {
                    animalToReturn = new Owl(name, weight, wingSize);
                }

                else
                {
                    animalToReturn = new Hen(name, weight, wingSize);
                }
            }

            else if (type == nameof(Mouse) || type == nameof(Dog))
            {
                var name = animalData[1];
                var weight = double.Parse(animalData[2]);
                var livingRegion = animalData[3];

                if (type == nameof(Mouse))
                {
                    animalToReturn = new Mouse(name, weight, livingRegion);
                }

                else
                {
                    animalToReturn = new Dog(name, weight, livingRegion);
                }
            }

            else if (type == nameof(Cat) || type == nameof(Tiger))
            {
                var name = animalData[1];
                var weight = double.Parse(animalData[2]);
                var livingRegion = animalData[3];
                var breed = animalData[4];

                if (type == nameof(Cat))
                {
                    animalToReturn = new Cat(name, weight, livingRegion, breed);
                }

                else
                {
                    animalToReturn = new Tiger(name, weight, livingRegion, breed);
                }
            }

            return animalToReturn;
        }
    }
}
