using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpinionPoll
{
    public class Family
    {
        // field

        // constructor
        public Family()
        {
            this.Members = new List<Person>();
        }

        // property
        public List<Person> Members { get; set; }

        // method
        public void AddMember(Person person)
        {
            this.Members.Add(person);
        }

        public Person GetOldestMember()
        {
            Person person = this.Members.OrderByDescending(p => p.Age).FirstOrDefault();

            return person;
        }

        // private method
    }
}
