using System;

namespace ConsoleConverterUSDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method

            double usdAmount = double.Parse(Console.ReadLine());

            double exchangeRate = 1.79549;
            double bgnAmount = usdAmount * exchangeRate;

            Console.WriteLine($"Converted amount to BGN: {bgnAmount:F5}");
        }
    }
}