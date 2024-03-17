using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            
            int startingYield = Convert.ToInt32(Console.ReadLine());
            int days = 0;
            int yield = 0;

            for (int i = startingYield; i > 99; i -= 10)
            {
                days++;
                yield += i;
                yield -= 26;
            }
            yield -= 26;

            Console.WriteLine($@"{days}");
            Console.WriteLine($@"{yield}");
        }
    }
}