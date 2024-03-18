using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                if (int.TryParse(input, out int intValue))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out float floatValue))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (bool.TryParse(input, out bool boolValue))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (char.TryParse(input, out char charValue))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}