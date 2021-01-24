using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string password = Console.ReadLine();

            // calculation
            bool isValid = PasswordLenght(password) && LetterAndDigits(password) && HasTwoDigits(password);

            // output
            if (isValid == true)
            {
                Console.WriteLine("Password is valid");
            }
            if (PasswordLenght(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (LetterAndDigits(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (HasTwoDigits(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        private static bool LetterAndDigits(string password)
        {
            foreach (char item in password)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool HasTwoDigits(string password)
        {
            int counter = 0;

            foreach (var item in password)
            {
                if (char.IsDigit(item))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool PasswordLenght(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
