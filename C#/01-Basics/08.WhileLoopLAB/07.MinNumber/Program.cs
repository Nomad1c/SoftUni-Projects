using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            int minNumber = int.MaxValue;
            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }

                int a = int.Parse(input);

                if (a < minNumber)
                {
                    minNumber = a;
                }
            }

            Console.WriteLine(minNumber);
        }
    }
}