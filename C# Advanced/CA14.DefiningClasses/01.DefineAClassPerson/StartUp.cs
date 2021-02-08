using DefiningClasses;
using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person personOne = new Person();
            Person personTwo = new Person(25);
            Person personThree = new Person("Peter", 24);
        }
    }
}
