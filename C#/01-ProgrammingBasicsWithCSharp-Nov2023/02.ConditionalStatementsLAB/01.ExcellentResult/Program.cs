using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        //The entry point for where our program begins
        { //Anything between these curly braces is the *Body* of the main method
            double num = Convert.ToDouble(Console.ReadLine());

            if (num >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}