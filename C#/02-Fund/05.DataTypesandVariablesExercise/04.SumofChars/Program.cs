using System;

namespace SumofCharts
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            /*
             * SUM OF CHARS
             * 
             * Sum the ASCII coden from n characters and prints the sum
             * ---
             * INPUT 1 = n
             * INPUT (n lines) = letters from the latin alphabet
             * ---
             * Print result in format:
             *                          "The sum equals: {totalSum}"
             * CONSTRAINS:
             *      n will be in interval (0-20)
             *      char will be upper or lower case from english alphabet
             *      will always recieve 1 letter per line
             */

            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char character = Convert.ToChar(Console.ReadLine());
                sum += (int)character;
            }

            Console.WriteLine($@"The sum equals: {sum}");
        }
    }
}