using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            // calculation
            var people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] personData = Console.ReadLine().Split();
                string name = personData[0];
                int age = int.Parse(personData[1]);

                Person currentPerson = new Person(name, age);
                people.Add(currentPerson);
            }

            List<Person> filterPeople = people.Where(p => p.Age > 30).OrderBy(first => first.Name).ToList();

            foreach (var item in filterPeople)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
