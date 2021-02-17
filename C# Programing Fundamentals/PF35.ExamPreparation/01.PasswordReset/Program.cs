using System;
using System.Linq;
using System.Text;

namespace _01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string password = Console.ReadLine();

            // calculation
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commnad = input.Split();
                string action = commnad[0];

                if (action == "TakeOdd")
                {
                    password = removeOddIndexCharacters(password);

                    Console.WriteLine(password);
                }

                else if (action == "Cut")
                {
                    int index = int.Parse(commnad[1]);
                    int length = int.Parse(commnad[2]);

                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }

                else
                {
                    string substring = commnad[1];
                    string substitute = commnad[2];

                    if (password.Contains(substring) == false)
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }

                    password = password.Replace(substring, substitute);
                    Console.WriteLine(password);
                }
            }

            // output
            Console.WriteLine($"Your password is: {password}");
        }

        static string removeOddIndexCharacters(string s)
        {

            // Stores the resultant string  
            string new_string = "";

            for (int i = 0; i < s.Length; i++)
            {

                // If the current index is prime  
                if (i % 2 == 0)
                {
                    // Skip the character  
                    continue;
                }
                // Otherwise, append the  
                // character  
                new_string += s[i];
            }

            // Return the modified string  
            return new_string;
        }
    }
}
