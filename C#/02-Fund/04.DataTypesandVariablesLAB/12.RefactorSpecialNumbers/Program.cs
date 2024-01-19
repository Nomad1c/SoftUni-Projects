using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                int currentNum = num;
                int sumOfDigits = 0;

                while (currentNum > 0)
                {
                    sumOfDigits += currentNum % 10;
                    currentNum /= 10;
                }

                bool isSpecialNum = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{num} -> {isSpecialNum}");
            }
        }
    }
}