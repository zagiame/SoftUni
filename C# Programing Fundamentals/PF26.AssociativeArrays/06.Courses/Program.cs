using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string input = string.Empty;

            // calculation
            var course = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] currentLine = input.Split(" : ");
                string name = currentLine[0];
                string student = currentLine[1];

                if (course.ContainsKey(name) == false)
                {
                    course.Add(name, new List<string>());
                }

                course[name].Add(student);
            }


            // output

            foreach (var item in course.OrderByDescending(first => first.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var student in course[item.Key].OrderBy(second => second))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
