using System;

namespace PrintASCII
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int startIndex = Convert.ToInt32(Console.ReadLine());
            int endIndex = Convert.ToInt32(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                char character = (char)i;
                Console.Write(character + " ");
            }

            Console.WriteLine();
        }
    }
}