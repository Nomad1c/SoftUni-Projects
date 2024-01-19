using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool isSpecial = IsSpecialNumber(i);
                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }

        static bool IsSpecialNumber(int number)
        {
            int sumOfDigits = 0;

            while (number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }

            return sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
        }
    }
}