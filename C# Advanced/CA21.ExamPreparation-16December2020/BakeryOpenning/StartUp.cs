namespace BakeryOpenning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Initialize the repository
            Bakery bakery = new Bakery("Barny", 10);
            //Initialize entity
            Employee employee = new Employee("Stephen", 40, "Bulgaria");
            //Print Employee
            Console.WriteLine(employee); //Employee: Stephen, 40 (Bulgaria)

            //Add Employee
            bakery.Add(employee);
            //Remove Employee
            Console.WriteLine(bakery.Remove("Employee name")); //false

            Employee secondEmployee = new Employee("Mark", 34, "UK");

            //Add Employee
            bakery.Add(secondEmployee);

            Employee oldestEmployee = bakery.GetOldestEmployee(); // Employee with name Stephen
            Employee employeeStephen = bakery.GetEmployee("Stephen"); // Employee with name Stephen
            Console.WriteLine(oldestEmployee); //Employee: Stephen, 40 (Bulgaria)
            Console.WriteLine(employeeStephen); //Employee: Stephen, 40 (Bulgaria)

            Console.WriteLine(bakery.Count); //2

            Console.WriteLine(bakery.Report());
            //Employees working at Bakery Barny:
            //Employee: Stephen, 40 (Bulgaria)
            //Employee: Mark, 34 (UK)
        }

        public class Employee
        {
            // constructor
            public Employee(string name, int age, string country)
            {
                Name = name;
                Age = age;
                Country = country;
            }

            // property
            public string Name { get; set; }
            public int Age { get; set; }
            public string Country { get; set; }

            // method
            public override string ToString()
            {
                string toPrint = $"Employee: {Name}, {Age} ({Country})";
                return toPrint;
            }
        }

        public class Bakery
        {
            // field
            private List<Employee> data;

            // constructor
            public Bakery(string name, int capacity)
            {
                data = new List<Employee>();
                Name = name;
                Capacity = capacity;
            }

            // property
            public string Name { get; set; }
            public int Capacity { get; set; }
            public int Count { get => data.Count(); }

            // method
            public void Add(Employee employee)
            {
                if (data.Count < Capacity)
                {
                    data.Add(employee);
                }
            }

            public bool Remove(string name)
            {
                return data.Remove(data.FirstOrDefault(first => first.Name == name));
            }

            public Employee GetOldestEmployee()
            {
                Employee oldest = data.OrderBy(first => first.Age).FirstOrDefault();
                return oldest;
            }

            public Employee GetEmployee(string name)
            {
                Employee get = data.FirstOrDefault(first => first.Name == name);
                return get;
            }

            public string Report()
            {
                StringBuilder text = new StringBuilder();
                text.AppendLine($"Employees working at Bakery {Name}:");

                foreach (var item in data)
                {
                    text.AppendLine($"Employee: {item.Name}, {item.Age} ({item.Country})");
                }

                return text.ToString();
            }
        }
    }
}
