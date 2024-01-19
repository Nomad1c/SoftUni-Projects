using System;

namespace CharstoString
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());

            string result = $"{char1}{char2}{char3}";
            Console.WriteLine(result);
        }
    }
}