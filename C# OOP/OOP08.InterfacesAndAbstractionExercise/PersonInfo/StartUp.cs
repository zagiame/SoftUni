using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main()
        {
            // input
            string input = string.Empty;
            var BDayList = new List<IBirthable>();

            while ((input = Console.ReadLine()) != "End")
            {
                var data = input.Split();
                var type = data[0];

                if (type == "Pet")
                {
                    var petName = data[1];
                    var petBirthday = data[2];
                    BDayList.Add(new Pet(petName, petBirthday));
                }

                else if (type == "Citizen")
                {
                    var name = data[1];
                    var age = int.Parse(data[2]);
                    var personID = data[3];
                    var bday = data[4];

                    BDayList.Add(new Citizen(name, age, personID, bday));
                }
            }

            var text = Console.ReadLine();

            // output
            var filtered = BDayList.Where(fisrt => fisrt.Birthdate.EndsWith(text)).ToList();

            foreach (var item in filtered)
            {
                Console.WriteLine(item.Birthdate);
            }

        }
    }
}
