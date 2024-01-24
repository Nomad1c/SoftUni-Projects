using System;

namespace ConsoleConverterformRadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            double radians = double.Parse(Console.ReadLine());

            double degrees = radians * 180 / Math.PI;

            Console.WriteLine(degrees);
        }
    }
}