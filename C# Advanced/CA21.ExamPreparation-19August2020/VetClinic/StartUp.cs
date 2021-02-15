using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Initialize the repository
            Clinic clinic = new Clinic(20);

            // Initialize entity
            Pet dog = new Pet("Ellias", 5, "Tim");

            // Print Pet
            Console.WriteLine(dog); // Ellias 5 (Tim)

            // Add Pet
            clinic.Add(dog);

            // Remove Pet
            Console.WriteLine(clinic.Remove("Ellias")); // True
            Console.WriteLine(clinic.Remove("Pufa")); // False

            Pet cat = new Pet("Bella", 2, "Mia");
            Pet bunny = new Pet("Zak", 4, "Jon");

            clinic.Add(cat);
            clinic.Add(bunny);

            // Get Oldest Pet
            Pet oldestPet = clinic.GetOldestPet();
            Console.WriteLine(oldestPet); // Zak 4 (Jon)

            // Get Pet
            Pet pet = clinic.GetPet("Bella", "Mia");
            Console.WriteLine(pet); // Bella 2 (Mia)

            // Count
            Console.WriteLine(clinic.Count); // 2

            // Get Statistics
            Console.WriteLine(clinic.GetStatistics());
            //The clinic has the following patients:
            //Bella Mia
            //Zak Jon

        }

        public class Clinic
        {
            // field
            private List<Pet> data;

            // constructor
            public Clinic(int capacity)
            {
                Capacity = capacity;
                data = new List<Pet>();
            }

            // propraty
            public int Capacity { get; set; }
            public int Count { get => data.Count(); }


            // method
            public void Add(Pet pet)
            {
                if (data.Count() < Capacity)
                {
                    data.Add(pet);
                }
            }

            public bool Remove(string name)
            {
                return data.Remove(data.FirstOrDefault(n => n.Name == name));
            }

            public Pet GetPet(string name, string owner)
            {
                Pet getCurrentPet = data.FirstOrDefault(n => n.Name == name && n.Owner == owner);

                return getCurrentPet;
            }

            public Pet GetOldestPet()
            {
                return data.OrderByDescending(item => item.Age).FirstOrDefault();
            }

            public string GetStatistics()
            {
                StringBuilder result = new StringBuilder();
                result.AppendLine("The clinic has the following patients:");

                foreach (var item in data)
                {
                    result.AppendLine($"Pet {item.Name} with owner: {item.Owner}");
                }

                return result.ToString();
            }
        }

        public class Pet
        {
            // constrctor
            public Pet(string name, int age, string owner)
            {
                Name = name;
                Age = age;
                Owner = owner;
            }

            // propraty
            public string Name { get; set; }
            public int Age { get; set; }
            public string Owner { get; set; }

            // method
            public override string ToString()
            {
                string toPrint = $"Name: {Name} Age: {Age} Owner: {Owner}";
                return toPrint;
            }

        }
    }
}
