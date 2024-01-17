using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            PassCheck(pass);
        }

        static void PassCheck(string text)
        {
            int validityCheck = 0;
            int counter = 0;

            if (text.Length >= 6 && text.Length <= 10)
            {
                validityCheck++;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (IsAlphaNumeric(text))
            {
                validityCheck++;
            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                validityCheck++;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (validityCheck == 3)
            {
                Console.WriteLine("Password is valid.");
            }
        }

        static bool IsAlphaNumeric(string text)
        {
            return text.All(Char.IsLetterOrDigit);
        }
    }
}
