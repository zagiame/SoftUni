namespace ClassroomProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        static void Main(string[] args)
        {
            // Initialize the repository
            Classroom classroom = new Classroom(10);
            // Initialize entities
            Student student = new Student("Peter", "Parker", "Geometry");
            Student studentTwo = new Student("Sarah", "Smith", "Algebra");
            Student studentThree = new Student("Sam", "Winchester", "Algebra");
            Student studentFour = new Student("Dean", "Winchester", "Music");
            // Print Student
            Console.WriteLine(student); // Student: First Name = Peter, Last Name = Parker, Subject = Geometry
                                        // Register Student
            string register = classroom.RegisterStudent(student);
            Console.WriteLine(register); // Added student Peter Parker
            string registerTwo = classroom.RegisterStudent(studentTwo);
            string registerThree = classroom.RegisterStudent(studentThree);
            string registerFour = classroom.RegisterStudent(studentFour);
            // Dismiss Student
            string dismissed = classroom.DismissStudent("Peter", "Parker");
            Console.WriteLine(dismissed); // Dismissed student Peter Parker
            string dismissedTwo = classroom.DismissStudent("Ellie", "Goulding");
            Console.WriteLine(dismissedTwo); // Student not found
                                             // Subject info
            string subjectInfo = classroom.GetSubjectInfo("Algebra");
            Console.WriteLine(subjectInfo);
            // Subject: Algebra
            // Students:
            // Sarah Smith
            // Sam Winchester
            string anotherInfo = classroom.GetSubjectInfo("Art");
            Console.WriteLine(anotherInfo); // No students enrolled for the subject
                                            // Get Student
            Console.WriteLine(classroom.GetStudent("Dean", "Winchester"));
            // Student: First Name = Dean, Last Name = Winchester, Subject = Music
        }

        class Student
        {
            // constructor
            public Student(string firstName, string lastName, string subject)
            {
                FirstName = firstName;
                LastName = lastName;
                Subject = subject;
            }

            //property
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Subject { get; set; }

            // method
            public override string ToString()
            {
                string toReturn = $"Student: First Name = {FirstName}, Last Name = {LastName}, Subject = {Subject}";
                return toReturn;
            }
        }

        class Classroom
        {
            // field
            private List<Student> data;

            // constructor
            public Classroom(int capacity)
            {
                data = new List<Student>();
                Capacity = capacity;
            }

            // property
            public int Capacity { get; set; }
            public int Count { get => data.Count(); }

            // method
            public string RegisterStudent(Student student)
            {
                if (data.Count < Capacity)
                {
                    data.Add(student);
                    return $"Added student {student.FirstName} {student.LastName}";
                }

                return $"No seats in the classroom";
            }

            public string DismissStudent(string firstName, string lastName)
            {
                Student currentStudent = data.FirstOrDefault(student =>
                student.FirstName == firstName &&
                student.LastName == lastName);

                if (currentStudent != null)
                {
                    data.Remove(currentStudent);
                    return $"Dismissed student {firstName} {lastName}";
                }

                return "Student not found";
            }

            public string GetSubjectInfo(string subject)
            {
                bool isValidSubject = data.Exists(student => student.Subject == subject);

                if (isValidSubject == true)
                {
                    StringBuilder text = new StringBuilder();
                    text.AppendLine($"Subject: {subject}");
                    text.AppendLine("Students:");

                    foreach (var item in data.Where(student => student.Subject == subject))
                    {
                        text.AppendLine($"{item.FirstName} {item.LastName}");
                    }

                    return text.ToString();
                }

                else
                {
                    return "No students enrolled for the subject";
                }

            }

            public int GetStudentsCount()
            {
                int count = data.Count();
                return count;
            }

            public Student GetStudent(string firstName, string lastName)
            {
                var currentStudent = data.FirstOrDefault(student =>
                student.FirstName == firstName &&
                student.LastName == lastName);

                return currentStudent;
            }
        }
    }
}