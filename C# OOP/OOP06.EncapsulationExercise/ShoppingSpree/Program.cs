using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, Person>();
            var products = new Dictionary<string, Product>();

            try
            {
                people = ReadPeople();
                products = ReadProducts();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                var data = input.Split();

                var personName = data[0];
                var productName = data[1];

                var person = people[personName];
                var product = products[productName];

                try
                {
                    person.AddProduct(product);
                    Console.WriteLine($"{personName} bought {productName}");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            foreach (var item in people.Values)
            {
                Console.WriteLine(item);
            }
        }

        private static Dictionary<string, Product> ReadProducts()
        {
            var result = new Dictionary<string, Product>();
            var input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in input)
            {
                var productData = part.Split('=', StringSplitOptions.RemoveEmptyEntries);

                var productName = productData[0];
                var cost = decimal.Parse(productData[1]);

                result[productName] = new Product(productName, cost);
            }

            return result;
        }

        private static Dictionary<string, Person> ReadPeople()
        {
            var result = new Dictionary<string, Person>();
            var input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in input)
            {
                var personData = part.Split('=', StringSplitOptions.RemoveEmptyEntries);

                var name = personData[0];
                var money = decimal.Parse(personData[1]);

                result[name] = new Person(name, money);
            }

            return result;
        }
    }
}
