using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            string input;
            int maxNumber = int.MinValue;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }

                int number = int.Parse(input);

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}