using System;

class Program
{
    static void Main()
    {
        string username = Console.ReadLine();
        string correctPassword = ReverseString(username);

        int attempts = 0;

        while (true)
        {
            string passwordAttempt = Console.ReadLine();

            if (passwordAttempt == correctPassword)
            {
                Console.WriteLine($"User {username} logged in.");
                break;
            }
            else
            {
                attempts++;

                if (attempts == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
