using System;

namespace ChristmasPreparation
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double total = 0;

            a *= 5.8;
            b *= 7.2;
            c *= 1.2;
            total = (a + b + c) * (100 - d) / 100;

            Console.WriteLine($"{total:F3}");
        }
    }
}